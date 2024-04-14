using Food_At_Home.Contracts;
using Food_At_Home.Data.Models;
using Food_At_Home.Extensions;
using Food_At_Home.Models.Restaurant;
using Food_At_Home.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static Food_At_Home.Notifications.NotificationConstants;

namespace Food_At_Home.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantService restaurantService;
        private readonly IDishService dishService;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly IUserService userService;
        private readonly IImageService imageService;

        public RestaurantController(IRestaurantService _restaurantService, IDishService _dishService, UserManager<User> _userManager, SignInManager<User> _signInManager, IUserService _userService, IImageService _imageService)
        {
            this.restaurantService = _restaurantService;
            this.dishService = _dishService;
            this.userManager = _userManager;
            this.signInManager = _signInManager;
            this.userService = _userService;
            this.imageService = _imageService;

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

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public IActionResult Add()
        {
            var model = new AddRestaurantViewModel();
            return View(model);
        }


        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Add(AddRestaurantViewModel model)
        {
            if (await userService.ExistsByEmail(model.Email))
            {
                ModelState.AddModelError(nameof(model.Email), "There is already registered user with this email");
            }

            if (await userService.ExistsByPhone(model.PhoneNumber))
            {
                ModelState.AddModelError(nameof(model.PhoneNumber), "There is already registered user with this phone number");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new User()
            {
                Name = model.Name,
                Email = model.Email,
                UserName = model.Email.Split('@')[0],
                PhoneNumber = model.PhoneNumber,
                City = model.City,
                Address = model.Address

            };

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "Restaurant");

                await restaurantService.Create(user.Id);
                if (model.ProfilePicture != null)
                {
                    user.ImageUrl = await imageService.UploadImage(model.ProfilePicture, "images", user);
                    await userManager.UpdateAsync(user);
                }


                return RedirectToAction("Index", "Home");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }

            return View(model);
        }

        //[HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(Guid Id)
        {
            try
            {
                await restaurantService.Delete(Id);

                TempData[WarningMessage] = "This restaurant was successfully deleted";

                return this.RedirectToAction("All", "Restaurant");
            }
            catch (Exception)
            {
                return this.GeneralError();
            }
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(Guid restaurantId)
        {
            try
            {
                var restaurant = await restaurantService.GetRestaurantForForm(restaurantId);
                return View(restaurant);
            }
            catch (Exception)
            {

                return this.GeneralError();
            }
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(Guid restaurantId, RestaurantFormModel model)
        {
            try
            {
                await restaurantService.EditRestaurant(restaurantId, model);
            }
            catch (Exception)
            {
                return this.GeneralError();
            }

            TempData[SuccessMessage] = "Successfully edited restaurant";

            return RedirectToAction("All", "Restaurant");
        }

        private IActionResult GeneralError()
        {
            this.TempData[ErrorMessage] =
                "Unexpected error occurred! Please try again later or contact administrator";

            return this.RedirectToAction("Index", "Home");
        }

    }
}
