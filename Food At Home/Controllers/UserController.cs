using Food_At_Home.Contracts;
using Food_At_Home.Data.Models;
using Food_At_Home.Models;
using Food_At_Home.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Food_At_Home.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly IUserService userService;
        private readonly ICustomerService customerService;
        private readonly IImageService imageService;

        public UserController(UserManager<User> userManager, SignInManager<User> signInManager, IUserService _userService, ICustomerService _customerService, IImageService _imageService)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.userService = _userService;
            this.customerService = _customerService;
            this.imageService = _imageService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register() 
        {
            if(User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("All", "");
            }

            var model = new RegisterViewModel();

            return View(model);
            
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (await userService.ExistsByEmail(model.Email))
            {
                ModelState.AddModelError(nameof(model.Email), "There is already registered user with this email");
            }


            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new User()
            {
                Name = model.Name,
                Email = model.Email,
                UserName = model.Email,
                Address = model.Address,
                PhoneNumber = model.PhoneNumber,
                City = model.City,

            };

            var result = await userManager.CreateAsync(user, model.Password);



            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "Customer");
                await customerService.Create(user.Id);

                if (model.ImageUrl != null)
                {
                    user.ImageUrl = await imageService.UploadImage(model.ImageUrl, "images", user);
                    await userManager.UpdateAsync(user);
                }

                await signInManager.SignInAsync(user, isPersistent: false);

                return RedirectToAction("Index", "Home");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login() 
        {
            //if (User?.Identity?.IsAuthenticated ?? false)
            //{
            //    return RedirectToAction("All", "");
            //}
            var model = new LoginViewModel();

            return View(model);
        }
        
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userManager.FindByEmailAsync(model.Email);

            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

            }

            ModelState.AddModelError(nameof(model.Email), "Invalid Login");
            return View(model);

        }


    }
}
