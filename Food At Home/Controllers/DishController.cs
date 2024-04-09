using Food_At_Home.Contracts;
using Food_At_Home.Extensions;
using Food_At_Home.Models.Dish;
using Food_At_Home.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static Food_At_Home.Notifications.NotificationConstants;

namespace Food_At_Home.Controllers
{
    public class DishController : Controller
    {
        private readonly IDishService dishService;
        private readonly ICategoryService categoryService;
        private readonly IRestaurantService restaurantService;
        private readonly ICustomerService customerService;

        public DishController(IDishService _dishService, ICategoryService _categoryService, IRestaurantService _restaurantService,
            ICustomerService _customerService)
        {
            this.dishService = _dishService;
            this.categoryService = _categoryService;
            this.restaurantService = _restaurantService;
            this.customerService = _customerService;

        }

        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Menu(Guid id, [FromQuery] DishesQueryModel model)
        {
            bool isRestaurant = await restaurantService.ExistsById(id);

            if (!isRestaurant)
            {
                TempData[ErrorMessage] = "Incorrect restaurant";

                return RedirectToAction("Index", "Home");
            }
            try
            {
                var restaurantId = await restaurantService.GetRestaurantId(id);

                AllDishesFilteredAndPages serviceModel = await dishService.DishesFiltered(model, (Guid)restaurantId);

                model.Dishes = serviceModel.Dishes;
                model.TotalDishes = serviceModel.TotalDishes;
                model.Categories = await categoryService.AllCategoryNames();


                return View("All", model);

            }
            catch (Exception ex)
            {
                TempData[ErrorMessage] = ex.Message;

                return RedirectToAction("All", "Restaurant");
            }

        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            bool isRestaurant = await restaurantService.ExistsById((Guid)User.GetId());
            if (!isRestaurant)
            {
                TempData[ErrorMessage] = "You should be a restaurant to add a dish";

                return RedirectToAction("Index", "Home");
            }

            var model = new DishFormModel()
            {
                Categories = await categoryService.AllCategories()
            };



            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(DishFormModel model)
        {
            Guid userId = (Guid)User.GetId()!;

            bool isRestaurant = await restaurantService.ExistsById((Guid)User.GetId());
            if (!isRestaurant)
            {
                TempData[ErrorMessage] = "You should be a restaurant to add a dish";

                return RedirectToAction("Index", "Home");
            }
            Guid restaurantId = (Guid)await restaurantService.GetRestaurantId(userId);

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await dishService.AddDish(restaurantId, model);

            this.TempData[SuccessMessage] = $"Successfully added dish {model.Name}";

            return RedirectToAction("Menu", new { id = restaurantId });
        }
    }
}
