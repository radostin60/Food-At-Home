using Food_At_Home.Models.Dish;

namespace Food_At_Home.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<DishCategoryModel>> AllCategories();


        Task<IEnumerable<string>> AllCategoryNames();

        Task<Guid> GetDishCategory(Guid dishId);
    }
}
