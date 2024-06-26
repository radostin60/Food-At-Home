﻿using Food_At_Home.Contracts;
using Food_At_Home.Extensions;
using Food_At_Home.Models;
using Microsoft.AspNetCore.Mvc;
using static Food_At_Home.Notifications.NotificationConstants;

namespace Food_At_Home.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IRestaurantService restaurantService;
        private readonly IDishService dishService;
        private readonly IPaymentService paymentService;
        private readonly ICustomerService customerService;

        public PaymentController(IRestaurantService _restaurantService, IDishService _dishService, IPaymentService _paymentService, ICustomerService _customerService)
        {
            this.restaurantService = _restaurantService;
            this.dishService = _dishService;
            this.paymentService = _paymentService;
            this.customerService = _customerService;
        }

        [HttpGet]
        public async Task<IActionResult> Payment()
        {
            bool isRestaurant = await restaurantService.ExistsById((Guid)User.GetId());
            if (isRestaurant)
            {
                Guid rId = await restaurantService.GetRestaurantId((Guid)User.GetId());
                TempData[ErrorMessage] = "You should be a client to pay for order!";

                return RedirectToAction("Menu", "Dish", new { id = rId });
            }

            var dishes = dishService.GetCartDishes(User.GetUsername());

            decimal amount = Math.Round((decimal)(dishes.Sum(d => d.Price * d.Quantity)), 2);

            PaymentFormModel model = new PaymentFormModel()
            {
                Amount = Math.Round((amount + amount * 0.05m + 5m), 2),
                RestaurantId = (Guid)dishes.FirstOrDefault().RestaurantId
            };

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Payment(PaymentFormModel model)
        {
            bool isRestaurant = await restaurantService.ExistsById((Guid)User.GetId());
            if (isRestaurant)
            {
                Guid rId = await restaurantService.GetRestaurantId((Guid)User.GetId());

                TempData[ErrorMessage] = "You should be a client to pay for order!";

                return RedirectToAction("Menu", "Dish", new { id = rId });

            }

            string[] expDate = model.ExpiryDate.Split('/', StringSplitOptions.RemoveEmptyEntries);

            if (int.Parse(expDate[0]) < DateTime.Now.Month || int.Parse($"20{expDate[1]}") < DateTime.Now.Year)
            {
                ModelState.AddModelError(nameof(model.ExpiryDate), "Expiry date should be before now.");
            }

            if (!ModelState.IsValid)
            {
                var dishes = dishService.GetCartDishes(User.GetUsername());
                model.Amount = (decimal)dishes.Sum(d => d.Price * d.Quantity);
                return View(model);
            }

            try
            {
                Guid customerId = (Guid)await customerService.GetCustomerId((Guid)User.GetId());
                Guid paymentId = await paymentService.CreatePayment(customerId, model);

                return RedirectToAction("Order", "Order",
                    new { restaurantId = model.RestaurantId, paymentId });
            }
            catch (Exception)
            {
                TempData[ErrorMessage] = "Unexpected Error occurred";
                return RedirectToAction("Index", "Home");
            }

        }
    }
}
