using Food_At_Home.Contracts;
using Food_At_Home.Data.Models.Enums;
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

        public async Task<IActionResult> UserOrders()
        {
            bool isRestaurant = await restaurantService.ExistsById((Guid)User.GetId());
            if (isRestaurant)
            {
                Guid rId = await restaurantService.GetRestaurantId((Guid)User.GetId());
                TempData[ErrorMessage] = "You should be a customer to order a dish";

                return RedirectToAction("Menu", "Dish", new { id = rId });
            }

            Guid customerId = (Guid)await customerService.GetCustomerId((Guid)User.GetId());

            try
            {
                var orders = await orderService.GetOrdersByCustomerId(customerId);
                return View("All", orders);
            }
            catch (Exception ex)
            {
                TempData[ErrorMessage] = ex.Message;

                return RedirectToAction("Index", "Home");
            }

        }

        public async Task<IActionResult> RestaurantOrders()
        {
            bool isRestaurant = await restaurantService.ExistsById((Guid)User.GetId());
            if (!isRestaurant)
            {
                TempData[ErrorMessage] = "You should be a restaurant to accept order";
                return RedirectToAction("UserOrders");
            }



            try
            {
                Guid restaurantId = await restaurantService.GetRestaurantId((Guid)User.GetId());
                var orders = await orderService.GetOrdersByRestaurantId(restaurantId);
                return View("All", orders);
            }
            catch (Exception ex)
            {
                TempData[ErrorMessage] = ex.Message;

                return RedirectToAction("Index", "Home");
            }


        }

        public async Task<IActionResult> SendOrder(Guid orderId)
        {

            bool isRestaurant = await restaurantService.ExistsById((Guid)User.GetId());
            if (!isRestaurant)
            {
                TempData[ErrorMessage] = "You should be a restaurant to accept order";
                return RedirectToAction("UserOrders");
            }

            Guid restaurantId = await restaurantService.GetRestaurantId((Guid)User.GetId());

            bool isOrderExists = await orderService.IsOrderExists(orderId);
            if (!isOrderExists)
            {
                TempData[ErrorMessage] = "This order does not exists";

                return RedirectToAction("UserOrders");
            }

            bool isInRestaurant = await orderService.IsOrderInRestaurant(orderId, restaurantId);
            if (!isInRestaurant)
            {
                TempData[ErrorMessage] = "The order should be in your restaurant to accept it";

                return RedirectToAction("UserOrders");
            }

            await orderService.ChangeStatusOrder(orderId, OrderStatus.Sent.ToString());

            return RedirectToAction("RestaurantOrders");

        }

        public async Task<IActionResult> DeliverOrder(Guid orderId)
        {
            bool isRestaurant = await restaurantService.ExistsById((Guid)User.GetId());
            if (!isRestaurant)
            {
                TempData[ErrorMessage] = "You should be a restaurant to accept order";
                return RedirectToAction("UserOrders");
            }

            Guid restaurantId = await restaurantService.GetRestaurantId((Guid)User.GetId());

            bool isOrderExists = await orderService.IsOrderExists(orderId);
            if (!isOrderExists)
            {
                TempData[ErrorMessage] = "This order does not exists";

                return RedirectToAction("UserOrders");
            }

            bool isInRestaurant = await orderService.IsOrderInRestaurant(orderId, restaurantId);
            if (!isInRestaurant)
            {
                TempData[ErrorMessage] = "The order should be in your restaurant to accept it";

                return RedirectToAction("UserOrders");
            }

            await orderService.ChangeStatusOrder(orderId, OrderStatus.Delivered.ToString());

            return RedirectToAction("RestaurantOrders");
        }

        public async Task<IActionResult> Accept(Guid orderId)
        {

            bool isRestaurant = await restaurantService.ExistsById((Guid)User.GetId());
            if (!isRestaurant)
            {
                TempData[ErrorMessage] = "You should be a restaurant to accept order";
                return RedirectToAction("UserOrders");
            }

            Guid restaurantId = await restaurantService.GetRestaurantId((Guid)User.GetId());

            bool isOrderExists = await orderService.IsOrderExists(orderId);
            if (!isOrderExists)
            {
                TempData[ErrorMessage] = "This order does not exists";

                return RedirectToAction("UserOrders");
            }

            bool isInRestaurant = await orderService.IsOrderInRestaurant(orderId, restaurantId);
            if (!isInRestaurant)
            {
                TempData[ErrorMessage] = "The order should be in your restaurant to accept it";

                return RedirectToAction("UserOrders");
            }

            var order = await orderService.GetOrderById(orderId);

            return View(order);


        }


        [HttpPost]
        public async Task<IActionResult> Accept(AcceptOrderFormModel model)
        {
            bool isRestaurant = await restaurantService.ExistsById((Guid)User.GetId());
            if (!isRestaurant)
            {
                TempData[ErrorMessage] = "You should be a restaurant to accept order";
                return RedirectToAction("UserOrders");
            }

            Guid restaurantId = await restaurantService.GetRestaurantId((Guid)User.GetId());

            bool isOrderExists = await orderService.IsOrderExists(model.Id);
            if (!isOrderExists)
            {
                TempData[ErrorMessage] = "This order does not exists";

                return RedirectToAction("UserOrders");
            }

            bool isInRestaurant = await orderService.IsOrderInRestaurant(model.Id, restaurantId);
            if (!isInRestaurant)
            {
                TempData[ErrorMessage] = "The order should be in your restaurant to accept it";

                return RedirectToAction("UserOrders");
            }

            if (model.DeliveryTime.Date < DateTime.Parse(model.OrderTime).Date)
            {
                ModelState.AddModelError(nameof(model.DeliveryTime), "Delivery date should be after order date");
            }
            if (model.DeliveryTime < DateTime.Parse(model.OrderTime))
            {
                ModelState.AddModelError(nameof(model.DeliveryTime), "Delivery time should be after order time");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await orderService.AddOrderDeliveryTime(model);
            await orderService.ChangeStatusOrder(model.Id, OrderStatus.Confirmed.ToString());

            return RedirectToAction("RestaurantOrders");
        }

    }
}
