using Food_At_Home.Contracts;
using Food_At_Home.Data;
using Food_At_Home.Data.Models;
using Food_At_Home.Models.Dish;
using Microsoft.EntityFrameworkCore;

namespace Food_At_Home.Services
{
    public class CategoryService: ICategoryService
    {
        private readonly FoodDbContext context;

        public CategoryService(FoodDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<DishCategoryModel>> AllCategories()
        {
            var categories = await context.Categories
                .Select(c => new DishCategoryModel()
                {
                    Id = c.Id,
                    Name = c.Name,

                })
                .ToListAsync();

            return categories;
        }

        public async Task<IEnumerable<string>> AllCategoryNames()
        {
            return await context.Categories
                .Select(c => c.Name)
                .ToListAsync();
        }

        public async Task<Guid> GetDishCategory(Guid dishId)
        {
            var dish = await context.Dishes
                .Include(d => d.Category)
                .FirstOrDefaultAsync(d => d.Id == dishId);

            

            return dish.Category.Id;
        }
    }
}
