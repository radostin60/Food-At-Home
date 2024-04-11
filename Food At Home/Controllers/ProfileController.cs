using Food_At_Home.Contracts;
using Food_At_Home.Extensions;
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
    }
}
