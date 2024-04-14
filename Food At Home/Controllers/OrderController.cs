using Food_At_Home.Contracts;
using Food_At_Home.Extensions;
using Food_At_Home.Models.Order;
using Microsoft.AspNetCore.Mvc;
using static Food_At_Home.Notifications.NotificationConstants;

namespace Food_At_Home.Controllers
{
    public class OrderController : Controller
    {
        private readonly IRestaurantService restaurantService;
        private readonly IDishService dishService;
        private readonly IOrderService orderService;
        private readonly ICustomerService customerService;
        private readonly IPaymentService paymentsService;

        public OrderController(IRestaurantService restaurantService, IDishService dishService, IOrderService orderService, ICustomerService customerService, IPaymentService paymentsService)
        {
            this.restaurantService = restaurantService;
            this.dishService = dishService;
            this.orderService = orderService;
            this.customerService = customerService;
            this.paymentsService = paymentsService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Order(Guid restaurantId, Guid paymentId)
        {
            bool isRestaurant = await restaurantService.ExistsById((Guid)User.GetId());
            if (isRestaurant)
            {
                Guid rId = await restaurantService.GetRestaurantId((Guid)User.GetId());
                TempData[ErrorMessage] = "You should be a client to order a dish";

                return RedirectToAction("Menu", "Dish", new { id = rId });
            }
            string username = User.GetUsername();

            var dishes = dishService.GetCartDishes(username);

            //dishes.ForEach(d => d.IsEnabled = false);

            OrderFormModel model = new OrderFormModel()
            {

                DishesForOrder = dishes,
                RestaurantId = restaurantId,
                PaymentId = paymentId,

            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Order(OrderFormModel model)
        {

            bool isRestaurant = await restaurantService.ExistsById((Guid)User.GetId());
            if (isRestaurant)
            {
                Guid rId = await restaurantService.GetRestaurantId((Guid)User.GetId());
                TempData[ErrorMessage] = "You should be a client to order a dish";

                return RedirectToAction("Menu", "Dish", new { id = rId });
            }

            string username = User.GetUsername();

            if (!ModelState.IsValid)
            {
                model.DishesForOrder = dishService.GetCartDishes(username);
                return View(model);
            }

            try
            {

                model.DishesForOrder = dishService.GetCartDishes(username);


                Guid customerId = (Guid)await customerService.GetCustomerId((Guid)User.GetId());

                var orderId = await orderService.CreateOrder(model, customerId);

                await paymentsService.AddPaymentOrderId(model.PaymentId, orderId);
            }
            catch (Exception ex)
            {
                TempData[ErrorMessage] = ex.Message;
                return View(model);
            }

            HttpContext.Session.Clear();

            TempData[SuccessMessage] = "Successfully placed order!";
            return RedirectToAction("UserOrders");
        }

    }
}
