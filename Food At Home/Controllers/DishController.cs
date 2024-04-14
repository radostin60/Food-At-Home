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

        //[HttpPost]
        public async Task<IActionResult> Delete(string id)
        {


            Guid restaurantId = await restaurantService.GetRestaurantId((Guid)User.GetId());
            bool isDishExists = await dishService.ExistsById(Guid.Parse(id));

            if (!isDishExists)
            {
                TempData[ErrorMessage] = "This dish does not exists!";

                return RedirectToAction("Menu", new { id = restaurantId });
            }

            bool isRestaurant = await restaurantService.ExistsById(restaurantId);

            if (!isRestaurant)
            {
                TempData[ErrorMessage] = "You should be restaurant!";

                return RedirectToAction("Index", "Home");
            }

            bool isOwner = await dishService.IsRestaurantOwnerToDish(Guid.Parse(id), restaurantId);

            if (!isOwner)
            {
                TempData[ErrorMessage] = "The dish must be in your menu to be deleted";

                return RedirectToAction("Menu", "Dish", new { id = restaurantId });
            }

            try
            {
                await dishService.Delete(Guid.Parse(id));

                TempData[WarningMessage] = "This dish was successfully deleted";

                return this.RedirectToAction("Menu", new { id = restaurantId });
            }
            catch (Exception)
            {
                return this.GeneralError();
            }
        }


        [HttpGet]
        public async Task<IActionResult> Edit(Guid dishId)
        {

            bool isRestaurant = await restaurantService.ExistsById((Guid)User.GetId());

            if (!isRestaurant)
            {
                TempData[ErrorMessage] = "You should be restaurant to edit a dish!";

                return RedirectToAction("Contact", "Home");
            }

            Guid restaurantId = await restaurantService.GetRestaurantId((Guid)User.GetId());

            bool isDishExists = await dishService.ExistsById(dishId);
            if (!isDishExists)
            {
                TempData[ErrorMessage] = "This dish does not exists!";

                return RedirectToAction("Menu", new { id = restaurantId });
            }




            bool isOwner = await dishService.IsRestaurantOwnerToDish(dishId, restaurantId);

            if (!isOwner)
            {
                TempData[ErrorMessage] = "The dish must be in your menu to be edited";

                return RedirectToAction("Menu", "Dish", new { id = restaurantId });
            }



            try
            {
                var dish = await dishService.GetDishById(dishId);
                dish.Categories = await categoryService.AllCategories();
                return View(dish);
            }
            catch (Exception)
            {

                return this.GeneralError();
            }




        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid dishId, DishFormModel model)
        {

            if (!ModelState.IsValid)
            {
                model.Categories = await categoryService.AllCategories();

                return View(model);
            }

            Guid restaurantId = await restaurantService.GetRestaurantId((Guid)User.GetId());
            bool isDishExists = await dishService.ExistsById(dishId);

            if (!isDishExists)
            {
                TempData[ErrorMessage] = "This dish does not exists!";

                return RedirectToAction("Menu", new { id = restaurantId });
            }

            bool isRestaurant = await restaurantService.ExistsById(restaurantId);

            if (!isRestaurant)
            {
                TempData[ErrorMessage] = "You should be restaurant!";

                return RedirectToAction("Contact", "Home");
            }

            bool isOwner = await dishService.IsRestaurantOwnerToDish(dishId, restaurantId);

            if (!isOwner)
            {
                TempData[ErrorMessage] = "The dish must be in your menu to be edited";

                return RedirectToAction("Menu", "Dish", new { id = restaurantId });
            }

            try
            {
                await dishService.EditDish(dishId, model);
            }
            catch (Exception)
            {
                return this.GeneralError();
            }

            TempData[SuccessMessage] = "Successfully edited dish";

            return RedirectToAction("Menu", "Dish", new { id = restaurantId });

        }


        [AllowAnonymous]
        public async Task<IActionResult> AddToCart(Guid dishId, int quantity = 1)
        {
            bool isRestaurant = await restaurantService.ExistsById((Guid)User.GetId());

            if (isRestaurant)
            {
                Guid restaurantId = await restaurantService.GetRestaurantId((Guid)User.GetId());
                TempData[ErrorMessage] = "You should be a client to order a dish";

                return RedirectToAction("Menu", new { id = restaurantId });

            }

            bool isDishExists = await dishService.ExistsById(dishId);

            if (!isDishExists)
            {
                TempData[ErrorMessage] = "This dish does not exists!";

                return RedirectToAction("All", "Restaurant");
            }

            string username = User.GetUsername();
            var cartDishes = dishService.GetCartDishes(username);
            var dish = await dishService.GetDishForOrderById(dishId);

            if (cartDishes == null || cartDishes.Count == 0)
            {
                await dishService.AddDishToCart(username, dishId, quantity);
                return RedirectToAction("Cart");

            }
            else if (cartDishes.FirstOrDefault().RestaurantId != dish.RestaurantId)
            {
                TempData[ErrorMessage] = "Dish for order should be at the same restaurant as the previous dish";
                return RedirectToAction("All", "Restaurant");
            }

            await dishService.AddDishToCart(username, dishId, quantity);
            return RedirectToAction("Cart");

        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Cart()
        {

            bool isRestaurant = await restaurantService.ExistsById((Guid)User.GetId());
            if (isRestaurant)
            {
                Guid restaurantId = await restaurantService.GetRestaurantId((Guid)User.GetId());
                TempData[ErrorMessage] = "You should be a client to order a dish";

                return RedirectToAction("Menu", new { id = restaurantId });
            }

            string username = User.GetUsername();


            var dishes = dishService.GetCartDishes(username);

            return View(dishes);

        }

        [AllowAnonymous]
        public async Task<IActionResult> RemoveFromCart(Guid dishId)
        {
            bool isRestaurant = await restaurantService.ExistsById((Guid)User.GetId());

            if (isRestaurant)
            {
                Guid restaurantId = await restaurantService.GetRestaurantId((Guid)User.GetId());
                TempData[ErrorMessage] = "You should be a client to order a dish";

                return RedirectToAction("Menu", new { id = restaurantId });
            }

            bool isDishExists = await dishService.ExistsById(dishId);

            if (!isDishExists)
            {
                TempData[ErrorMessage] = "This dish does not exists!";

                return RedirectToAction("All", "Restaurant");
            }


            List<OrderDishView> dishes =
                HttpContext.Session.GetObjectFromJson<List<OrderDishView>>($"cart{User.GetUsername()}");

            var dishToRemove = dishes.FirstOrDefault(d => d.Id == dishId);

            if (dishes.Remove(dishToRemove))
            {
                HttpContext.Session.SetObjectAsJson($"cart{User.GetUsername()}", dishes);
            }
            else
            {
                TempData[ErrorMessage] = "This dish is not is your cart";
                HttpContext.Session.SetObjectAsJson($"cart{User.GetUsername()}", dishes);

                return RedirectToAction("Cart");
            }

            TempData[SuccessMessage] = "Successfully removed dish from cart";

            return RedirectToAction("Cart");

        }


        [AllowAnonymous]
        public async Task<IActionResult> DecreaseDishQuantity(Guid dishId)
        {
            bool isRestaurant = await restaurantService.ExistsById((Guid)User.GetId());

            if (isRestaurant)
            {
                Guid restaurantId = await restaurantService.GetRestaurantId((Guid)User.GetId());
                TempData[ErrorMessage] = "You should be a client to order a dish";

                return RedirectToAction("Menu", new { id = restaurantId });

            }
            bool isDishExists = await dishService.ExistsById(dishId);

            if (!isDishExists)
            {
                TempData[ErrorMessage] = "This dish does not exists!";

                return RedirectToAction("All", "Restaurant");
            }

            string username = User.GetUsername();

            dishService.DecreaseDishQuantity(username, dishId);

            return RedirectToAction("Cart");
        }

        private IActionResult GeneralError()
        {
            this.TempData[ErrorMessage] =
                "Unexpected error occurred! Please try again later or contact administrator";

            return this.RedirectToAction("Index", "Home");
        }
    }
}
