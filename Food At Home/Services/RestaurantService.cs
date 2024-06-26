﻿using Food_At_Home.Contracts;
using Food_At_Home.Data;
using Food_At_Home.Data.Models;
using Food_At_Home.Models.Dish;
using Food_At_Home.Models.Restaurant;
using Microsoft.EntityFrameworkCore;

namespace Food_At_Home.Services
{
    public class RestaurantService:IRestaurantService
    {
        private readonly FoodDbContext context;
        private readonly IImageService imageService;

        public RestaurantService(FoodDbContext context, IImageService _imageService)
        {
            this.context = context;
            this.imageService = _imageService;
        }

        public async Task<bool> ExistsById(Guid id)
        {
            var restaurant = await context.Restaurants.Where(r => r.UserId == id || r.Id == id)
                .FirstOrDefaultAsync();

            return restaurant != null;
        }

        public async Task Create(Guid userId)
        {
            var restaurant = new Restaurant()
            {
                UserId = userId,
            };

            await context.AddAsync(restaurant);
            await context.SaveChangesAsync();
        }

        public async Task<RestaurantDetailsViewModel?> GetRestaurantById(Guid id)
        {
            var restaurant = await context.Restaurants
                .Where(r => r.Id == id )
                .Select(r => new RestaurantDetailsViewModel()
                {
                    Id = r.Id,
                    ImageUrl = r.User.ImageUrl,
                    Name = r.User.Name,
                    Description = r.Description,
                    City = r.User.City,
                    Address = r.User.Address
                })
                .FirstOrDefaultAsync();


            return restaurant;
        }

        public async Task<Guid> GetRestaurantId(Guid id)
        {
            var restaurantId = await context.Restaurants
                .Where(r => r.UserId == id || r.Id == id)
                .Select(r => r.Id)
                .FirstOrDefaultAsync();

            if (restaurantId == null)
            {
              throw new NullReferenceException("This restaurant doesn't exists");
            }

            return restaurantId;
        }

        public async Task<List<RestaurantViewModel>> GetRestaurantsAsync()
        {
            var restaurants = await context.Restaurants
                .Select(r => new RestaurantViewModel()
                {
                    Id = r.Id,
                    Name = r.User.Name,
                    ImageUrl = r.User.ImageUrl!
                })
                .ToListAsync();

            return restaurants;
        }

        public async Task Delete(Guid Id)
        {
            var restaurant = await context.Restaurants
                .FirstAsync(d => d.Id == Id);

            this.context.Remove(restaurant);
            await this.context.SaveChangesAsync();

        }

        public async Task EditRestaurant(Guid restaurantId, RestaurantFormModel model)
        {
            var restaurant = await context.Restaurants
                .Include(r => r.User)
                .FirstOrDefaultAsync(d => d.Id == restaurantId);

            restaurant.User.Name = model.Name;
            restaurant.Description = model.Description;
            restaurant.User.PhoneNumber = model.PhoneNumber;
            restaurant.User.City = model.City;
            restaurant.User.Address = model.Address;

            await context.SaveChangesAsync();
        }

        public async Task<RestaurantFormModel?> GetRestaurantForForm(Guid id)
        {
            var restaurant = await context.Restaurants
                .Where(r => r.Id == id)
                .Select(r => new RestaurantFormModel()
                {
                    Id = r.Id,
                    Name = r.User.Name,
                    Description = r.Description,
                    City = r.User.City,
                    Address = r.User.Address,
                    PhoneNumber = r.User.PhoneNumber
                })
                .FirstOrDefaultAsync();


            return restaurant;
        }
    }
}
