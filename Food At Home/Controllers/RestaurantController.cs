using Food_At_Home.Contracts;
using Food_At_Home.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Food_At_Home.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantService restaurantService;
        private readonly IDishService dishService;

        public RestaurantController(IRestaurantService _restaurantService, IDishService _dishService)
        {
            this.restaurantService = _restaurantService;
            this.dishService = _dishService;

        }

        public async Task<IActionResult> All()
        {
            Guid userId = (Guid)User.GetId()!;
            bool isRestaurant = await restaurantService.ExistsById(userId);

            if (isRestaurant)
            {
                TempData[ErrorMessage] = "You should be a customer to see restaurants";
                return RedirectToAction("Index", "Home");
            }

            var restaurants = await restaurantService.GetRestaurantsAsync();

            return View(restaurants);
        }


        public async Task<IActionResult> Details(Guid id)
        {
            Guid userId = (Guid)User.GetId()!;
            bool isRestaurant = await restaurantService.ExistsById(userId);
            if (isRestaurant)
            {
                TempData[ErrorMessage] = "You should be a customer to see restaurants";
                return RedirectToAction("Index", "Home");
            }

            var restaurant = await restaurantService.GetRestaurantById(id);

            return View(restaurant);
        }
    }
}
