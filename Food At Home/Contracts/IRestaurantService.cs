﻿using Food_At_Home.Models.Dish;
using Food_At_Home.Models.Restaurant;

namespace Food_At_Home.Contracts
{
    public interface IRestaurantService
    {
        Task<List<RestaurantViewModel>> GetRestaurantsAsync();

        Task<RestaurantDetailsViewModel?> GetRestaurantById(Guid id);

        Task<RestaurantFormModel?> GetRestaurantForForm(Guid id);

        Task<Guid> GetRestaurantId(Guid userId);

        Task<bool> ExistsById(Guid userId);

        Task Create(Guid userId);

        Task Delete(Guid restaurantId);

        Task EditRestaurant(Guid restaurantId, RestaurantFormModel model);
    }
}
