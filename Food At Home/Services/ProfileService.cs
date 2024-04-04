using Food_At_Home.Contracts;
using Food_At_Home.Data;
using Food_At_Home.Data.Models;
using Food_At_Home.Models;

namespace Food_At_Home.Services
{
    public class ProfileService: IProfileService
    {
        private readonly FoodDbContext context;
        private readonly IOrderService orderService;
        private readonly IRestaurantService restaurantService;
        private readonly IImageService imageService;
        private readonly IDishService dishService;

        public ProfileService(FoodDbContext context, IOrderService orderService, IRestaurantService restaurantService, IImageService imageService, IDishService dishService)
        {
            this.context = context;
            this.orderService = orderService;
            this.restaurantService = restaurantService;
            this.imageService = imageService;
            this.dishService = dishService;
        }

        public async Task Edit(Guid userId, EditProfileModel model)
        {
            var user = await context.Users.FindAsync(userId);

            if (user == null)
            {
                throw new NullReferenceException("This user does not exists");
            }

            user.Name = model.Name;
            user.Address = model.Address;
            user.Email = model.Email;
            user.City = model.City;
            user.PhoneNumber = model.PhoneNumber;

            if (model.ImageUrl != null)
                user.ImageUrl = await imageService.UploadImage(model.ImageUrl, "images", user);

            await context.SaveChangesAsync();
        }

        public async Task<ProfileViewModel> MyProfile(Guid userId, bool IsRestaurant)
        {
            var user = await context.Users.FindAsync(userId);
            if (user == null)
            {
                throw new NullReferenceException("This user does not exists");
            }


            var profile = new ProfileViewModel()
            {
                Id = userId,
                Name = user.Name,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                City = user.City,
                Address = user.Address,
                ProfilePictureUrl = user.ImageUrl,
            };

            if (IsRestaurant)
            {

                var restaurantId = await restaurantService.GetRestaurantId(userId);
                var orders = await orderService.GetOrdersIdByRestaurantId(restaurantId);
                var restaurant = await restaurantService.GetRestaurantById(restaurantId);

                profile.OrdersCount = orders.Count();
                profile.Description = restaurant.Description;
                profile.MenuPhotos = await dishService.AllDishesImagesByRestaurantId(restaurantId);

            }
            else
            {
                profile.OrdersCount = await orderService.GetOrdersCountByUserId(userId);
            }

            return profile;

        }
    }
}
