using Food_At_Home.Contracts;
using Food_At_Home.Data;
using Food_At_Home.Data.Models;

namespace Food_At_Home.Services
{
    public class DishService: IDishService
    {
        private readonly FoodDbContext _context;

        public DishService(FoodDbContext context)
        {
            _context = context;
        }

        /*  public async Task<Dish> CreateDishAsync(CreateDishViewModel model)
        {
            var dish = new Dish
            {
                Name = model.Name,
                CategoryId = model.CategoryId,
                Ingredients = model.Ingredients,
                Description = model.Description,
                Price = model.Price,
                ImageUrl = model.ImageUrl,
                RestaurantId = model.RestaurantId,
                Quantity = model.Quantity
            };

            _context.Dishes.Add(dish);
            await _context.SaveChangesAsync();

            return dish;
        }  */
    }
}
