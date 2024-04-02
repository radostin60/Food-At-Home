using Food_At_Home.Models.Dish;

namespace Food_At_Home.Contracts
{
    public interface IDishService
    {
        Task<List<string>> AllDishesImagesByRestaurantId(Guid restaurantId);

        Task AddDish(Guid restaurantId, DishFormModel model);

        Task<List<DishViewModel>> GetDishesByRestaurantId(Guid restaurantId);

        Task<DishFormModel?> GetDishById(Guid id);

        Task<bool> ExistsById(Guid dishId);

        Task<bool> IsRestaurantOwnerToDish(Guid dishId, Guid restaurantId);

        Task EditDish(Guid dishId, DishFormModel model);

        Task Delete(Guid dishId);

        Task<PreDeleteDishViewModel> DishForDeleteById(Guid dishId);

        Task<AllDishesFilteredAndPages> DishesFiltered(DishesQueryModel model, string id);
        Task<AllDishesFilteredAndPages> AllDishesFiltered(DishesQueryModel model);

        Task<OrderDishView?> GetDishForOrderById(Guid id);

        Task AddDishToCart(string username, Guid dishId, int quantity);

        void DecreaseDishQuantity(string username, Guid dishId);

        List<OrderDishView> GetCartDishes(string username);
    }
}
