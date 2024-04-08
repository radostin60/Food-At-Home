using Food_At_Home.Contracts;
using Food_At_Home.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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

                AllDishesFilteredAndPages serviceModel = await dishService.DishesFiltered(model, restaurantId);

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
    }
}
