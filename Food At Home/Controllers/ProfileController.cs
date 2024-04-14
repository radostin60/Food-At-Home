using Food_At_Home.Contracts;
using Food_At_Home.Extensions;
using Food_At_Home.Models;
using Microsoft.AspNetCore.Mvc;
using static Food_At_Home.Notifications.NotificationConstants;

namespace Food_At_Home.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IProfileService profileService;
        private readonly IRestaurantService restaurantService;
        private readonly IUserService userService;

        public ProfileController(IProfileService profileService, IRestaurantService restaurantService, IUserService userService)
        {
            this.profileService = profileService;
            this.restaurantService = restaurantService;
            this.userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> MyProfile()
        {
            try
            {
                bool isRestaurant = await restaurantService.ExistsById((Guid)User.GetId());
                var myProfile = await profileService.MyProfile((Guid)User.GetId(), isRestaurant);

                myProfile.IsRestaurant = isRestaurant;


                return View("Profile", myProfile);

            }
            catch (Exception ex)
            {
                TempData[ErrorMessage] = ex.Message;

                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            try
            {
                var user = await userService.GetUserByIdAsync(id);

                var model = new EditProfileModel()
                {
                    Id = id,
                    Name = user.Name,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    City = user.City,
                   // Country = user.Country,
                    Address = user.Address,

                };

                return View(model);
            }
            catch (Exception ex)
            {
                TempData[ErrorMessage] = ex.Message;

                return RedirectToAction("Index", "Home");
            }
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, EditProfileModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }


            try
            {
                await profileService.Edit(id, model);

                return RedirectToAction("MyProfile");
            }
            catch (Exception e)
            {
                TempData[ErrorMessage] = e.Message;

                return RedirectToAction("Index", "Home");

            }
        }
    }
}
