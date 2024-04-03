using Food_At_Home.Contracts;
using Food_At_Home.Data;
using Food_At_Home.Data.Models;
using Food_At_Home.Models.Dish;
using Microsoft.EntityFrameworkCore;

namespace Food_At_Home.Services
{
    public class DishService: IDishService
    {
        private readonly FoodDbContext _context;
        private readonly IImageService imageService;

        public DishService(FoodDbContext context, IImageService _imageService)
        {
            _context = context;
            imageService = _imageService;
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


            await _context.AddAsync(dish);
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
                    Id = rd.Id,
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

        
        ///////TO DO --- Cart And Filter



    }
}
