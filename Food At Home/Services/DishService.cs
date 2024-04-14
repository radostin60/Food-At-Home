using Food_At_Home.Contracts;
using Food_At_Home.Data;
using Food_At_Home.Data.Models;
using Food_At_Home.Data.Models.Enums;
using Food_At_Home.Models.Dish;
using Microsoft.EntityFrameworkCore;
using Food_At_Home.Extensions;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace Food_At_Home.Services
{
    public class DishService: IDishService
    {
        private readonly FoodDbContext _context;
        private readonly IImageService imageService;
        private readonly IHttpContextAccessor accessor;

        public DishService(FoodDbContext context, IImageService _imageService, IHttpContextAccessor accessor)
        {
            _context = context;
            imageService = _imageService;
            this.accessor = accessor;
        }

        public async Task AddDish(Guid restaurantId, DishFormModel model)
        {

            Dish dish = new Dish
            {
                Name = model.Name,
                Price = model.Price,
                Description = model.Description,
                Ingredients = model.Ingredients,
                CategoryId = model.CategoryId,
                Quantity = model.Quantity,
                RestaurantId = restaurantId
            };

            if (model.ImageUrl != null)
            {
                dish.ImageUrl = await imageService.UploadImage(model.ImageUrl, "images", dish);

            }


            _context.Dishes.Add(dish);
            await _context.SaveChangesAsync();


        }

        public async Task EditDish(Guid dishId, DishFormModel model)
        {
            var dish = await _context.Dishes
                .FirstOrDefaultAsync(d => d.Id == dishId);

            dish.Name = model.Name;
            dish.Description = model.Description;
            dish.CategoryId = model.CategoryId;
            dish.Ingredients = model.Ingredients;
            dish.Quantity = model.Quantity;
            dish.Price = model.Price;

            if (model.ImageUrl != null)
                dish.ImageUrl = await imageService.UploadImage(model.ImageUrl, "images", dish);

            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistsById(Guid dishId)
        {
            var dish = await _context.Dishes
                .FirstOrDefaultAsync(d => d.Id == dishId);

            return dish != null;



        }

        public async Task Delete(Guid dishId)
        {
            var dish = await _context.Dishes
                .FirstAsync(d => d.Id == dishId);

            this._context.Remove(dish);
            await this._context.SaveChangesAsync();

        }

        public async Task<PreDeleteDishViewModel> DishForDeleteById(Guid dishId)
        {
            var dish = await _context.Dishes
                .Where(d => d.Id == dishId)
                .Select(d => new PreDeleteDishViewModel()
                {
                    Id = d.Id,
                    Name = d.Name,
                    Ingredients = d.Ingredients,
                    ImageUrl = d.ImageUrl
                })
                .FirstOrDefaultAsync();

            return dish!;


        }

        public async Task<List<string>> AllDishesImagesByRestaurantId(Guid restaurantId)
        {
            var dishes = await _context.Dishes
                .Where(rd => rd.RestaurantId == restaurantId)
                .Select(rd => rd.ImageUrl)
                .ToListAsync();

            return dishes!;

        }

        public async Task<DishFormModel?> GetDishById(Guid id)
        {
            var dish = await _context.Dishes
                .Where(rd => rd.Id == id && rd.Quantity > 0)
                .Select(rd => new DishFormModel()
                {
                    Name = rd.Name,
                    Description = rd.Description,
                    Ingredients = rd.Ingredients,
                    Price = rd.Price,
                    ImageUrl = null,
                    Quantity = rd.Quantity,
                    CategoryId = rd.CategoryId

                })
                .FirstOrDefaultAsync();

            return dish;
        }

        public async Task<bool> IsRestaurantOwnerToDish(Guid dishId, Guid restaurantId)
        {
            var dish = await _context.Dishes
                .FirstOrDefaultAsync(d => d.Id == dishId);

            if (dish == null)
            {
                return false;
            }

            return dish.RestaurantId == restaurantId;
        }

        public async Task<OrderDishView?> GetDishForOrderById(Guid id)
        {
            var dish = await _context.Dishes
                .Where(d => d.Id == id)
                .Select(d => new OrderDishView()
                {
                    Id = d.Id,
                    ImageUrl = d.ImageUrl,
                    Name = d.Name,
                    Ingredients = d.Ingredients,
                    Price = d.Price,
                    Quantity = 1,
                    RestaurantId = d.RestaurantId
                })
                .FirstOrDefaultAsync();

            return dish;
        }

        public async Task<List<DishViewModel>> GetDishesByRestaurantId(Guid restaurantId)
        {
            var dihes = await _context.Dishes
                .Where(rd => rd.RestaurantId == restaurantId && rd.Quantity > 0)
                .Select(rd => new DishViewModel()
                {
                    Id = rd.Id.ToString(),
                    Name = rd.Name,
                    Description = rd.Description,
                    Ingredients = rd.Ingredients,
                    Price = rd.Price,
                    DishImageUrl = rd.ImageUrl, 
                    RestaurantUserId = rd.Restaurant.UserId
                })
                .ToListAsync();

            return dihes!;
        }


        public async Task<AllDishesFilteredAndPages> DishesFiltered(DishesQueryModel model, Guid id)
        {
            IQueryable<Dish> dishesQuery = _context.Dishes
                .Where(d => d.RestaurantId == id);

            if (!string.IsNullOrEmpty(model.Category))
            {
                dishesQuery = dishesQuery
                    .Where(d => d.Category.Name == model.Category);
            }

            

            dishesQuery = model.DishSorting switch
            {
                DishSorting.Name => dishesQuery.OrderBy(d => d.Name),
                DishSorting.PriceAscending => dishesQuery.OrderBy(d => d.Price),
                DishSorting.PriceDescending => dishesQuery.OrderByDescending(d => d.Price),
                DishSorting.IngredientsAscending => dishesQuery.OrderBy(d => d.Ingredients),
                DishSorting.IngredientsDescending => dishesQuery.OrderByDescending(d => d.Ingredients)


            };

            IEnumerable<DishViewModel> dishModel = await dishesQuery
                .Skip((model.CurrentPage - 1) * model.DishesPerPage)
                .Take(model.DishesPerPage)
                .Select(d => new DishViewModel()
                {
                    Id = d.Id.ToString(),
                    Name = d.Name,
                    Ingredients = d.Ingredients,
                    Description = d.Description,
                    Price = d.Price,
                    DishImageUrl = d.ImageUrl,
                    RestaurantUserId = d.Restaurant.UserId
                })
                .ToListAsync();

            int totalDishes = dishesQuery.Count();

            return new AllDishesFilteredAndPages()
            {
                Dishes = dishModel,
                TotalDishes = totalDishes
            };
        }

        public async Task<AllDishesFilteredAndPages> AllDishesFiltered(DishesQueryModel model)
        {
            IQueryable<Dish> dishesQuery = _context.Dishes;

            if (!string.IsNullOrEmpty(model.Category))
            {
                dishesQuery = dishesQuery
                    .Where(d => d.Category.Name == model.Category);
            }

           

            dishesQuery = model.DishSorting switch
            {
                DishSorting.Name => dishesQuery.OrderBy(d => d.Name),
                DishSorting.PriceAscending => dishesQuery.OrderBy(d => d.Price),
                DishSorting.PriceDescending => dishesQuery.OrderByDescending(d => d.Price),
                DishSorting.IngredientsAscending => dishesQuery.OrderBy(d => d.Ingredients),
                DishSorting.IngredientsDescending => dishesQuery.OrderByDescending(d => d.Ingredients)


            };

            IEnumerable<DishViewModel> dishModel = await dishesQuery
                .Skip((model.CurrentPage - 1) * model.DishesPerPage)
                .Take(model.DishesPerPage)
                .Select(d => new DishViewModel()
                {
                    Id = d.Id.ToString(),
                    Name = d.Name,
                    Ingredients = d.Ingredients,
                    Description = d.Description,
                    Price = d.Price,
                    DishImageUrl = d.ImageUrl,
                    RestaurantUserId = d.Restaurant.UserId
                })
                .ToListAsync();
            int totalDishes = dishesQuery.Count();

            return new AllDishesFilteredAndPages()
            {
                Dishes = dishModel,
                TotalDishes = totalDishes
            };
        }


        public async Task AddDishToCart(string username, Guid dishId, int quantity)
        {

            if (accessor.HttpContext.Session.GetObjectFromJson<List<OrderDishView>>($"cart{username}") == null)
            {
                var dish = await this.GetDishForOrderById(dishId);
                List<OrderDishView> cart = new List<OrderDishView>();
                cart.Add(dish);
                accessor.HttpContext.Session.SetObjectAsJson($"cart{username}", cart);

            }
            else
            {
                List<OrderDishView> cart = accessor.HttpContext.Session.GetObjectFromJson<List<OrderDishView>>($"cart{username}");
                var orderDish = cart.Where(d => d.Id == dishId).FirstOrDefault();
                if (orderDish != null)
                {
                    cart[cart.IndexOf(orderDish)].Quantity += quantity;
                }
                else
                {
                    var dish = await this.GetDishForOrderById(dishId);
                    cart.Add(dish);
                }

                accessor.HttpContext.Session.SetObjectAsJson($"cart{username}", cart);
            }

        }

        public void DecreaseDishQuantity(string username, Guid dishId)
        {
            List<OrderDishView> cart = accessor.HttpContext.Session.GetObjectFromJson<List<OrderDishView>>($"cart{username}");
            if (cart != null)
            {
                var orderDish = cart.FirstOrDefault(d => d.Id == dishId);
                if (orderDish.Quantity > 1)
                {
                    cart[cart.IndexOf(orderDish)].Quantity -= 1;
                }
                else
                {
                    var dishToRemove = cart.FirstOrDefault(d => d.Id == dishId);

                    if (cart.Remove(dishToRemove))
                    {
                        accessor.HttpContext.Session.SetObjectAsJson($"cart{username}", cart);
                    }
                }

            }

            accessor.HttpContext.Session.SetObjectAsJson($"cart{username}", cart);
        }

        public List<OrderDishView> GetCartDishes(string username)
        {
            return accessor.HttpContext.Session.GetObjectFromJson<List<OrderDishView>>($"cart{username}");
        }

    }
}
