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

        public DishService(FoodDbContext context)
        {
            _context = context;
        }

        public async Task AddDish(Guid restaurantId, CreateDishViewModel model)
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

        public async Task EditDish(Guid dishId, CreateDishViewModel model)
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
                .Where(d => d.Id == dishId)
                .FirstOrDefaultAsync();


            await _context.SaveChangesAsync();

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
                    ImageUrl = d.DishUrlImage
                })
                .FirstOrDefaultAsync();

            return dish!;


        }




    }
}
