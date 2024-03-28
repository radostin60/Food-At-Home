using Food_At_Home.Models.Restaurant;

namespace Food_At_Home.Contracts
{
    public interface IRestaurantService
    {
        Task<List<RestaurantViewModel>> GetRestaurantsAsync();

        Task<RestaurantDetailsViewModel?> GetRestaurantById(Guid id);

        Task<string> GetRestaurantId(Guid userId);

        Task<bool> ExistsById(Guid userId);

        Task Create(Guid userId);
    }
}
