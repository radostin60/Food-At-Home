using Food_At_Home.Contracts;
using Food_At_Home.Data;
using Food_At_Home.Data.Models;
using Food_At_Home.Data.Models.Enums;
using Food_At_Home.Models.Order;
using Microsoft.EntityFrameworkCore;

namespace Food_At_Home.Services
{
    public class OrderService: IOrderService
    {
        private readonly FoodDbContext context;

        public OrderService(FoodDbContext context)
        {
            this.context = context;
        }

        public async Task<Guid> CreateOrder(OrderFormModel model, Guid userId)
        {
            Order order = new Order()
            {
                CustomerId = userId,
                Address = model.Address,
                OrderTime = DateTime.Now,
                Price = (decimal)(model.DishesForOrder.Select(d => d.Price * d.Quantity).Sum() +
                0.05m * model.DishesForOrder.Select(d => d.Price * d.Quantity).Sum() + 5),
                RestaurantId = model.RestaurantId,
                Status = OrderStatus.Waiting.ToString(),
                PaymentId = model.PaymentId

            };

            List<OrderDish> orderDishes = new List<OrderDish>();

            foreach (var dish in model.DishesForOrder)
            {

                OrderDish orderDish = new OrderDish()
                {
                    OrderId = order.Id,
                    DishId = dish.Id,
                    Quantity = dish.Quantity,
                };

                orderDishes.Add(orderDish);
            }

            order.Dishes = orderDishes;

            await context.AddAsync(order);

            await context.SaveChangesAsync();

            return order.Id;
        }


        public async Task<List<Guid>> GetOrdersIdByRestaurantId(Guid restaurantId)
        {

            var orders = await context.Orders
                .Where(o => o.RestaurantId == restaurantId)
                .Select(o => o.Id)
                .ToListAsync();

            return orders;
        }

        public async Task<int> GetOrdersCountByUserId(Guid userId)
        {
            var orders = await context.Orders
                .Where(o => o.Customer.User.Id == userId)
                .ToListAsync();

            return orders.Count;

        }

        public async Task<List<OrderViewModel>> GetOrdersByCustomerId(Guid clientId)
        {
            var orders = await context.Orders
                .Where(o => o.CustomerId == clientId && o.Status != OrderStatus.Delivered.ToString())
                .OrderBy(o => o.OrderTime)
                .Select(o => new OrderViewModel()
                {
                    Id = o.Id,
                    RestaurantName = o.Restaurant.User.Name,
                    DeliveryAddress = o.Address,
                    DeliveryTime = o.DeliveryTime.HasValue
                        ? $"{o.DeliveryTime.Value.ToShortTimeString()} {o.DeliveryTime.Value.ToShortDateString()}"
                        : string.Empty,
                    OrderTime = $"{o.OrderTime.ToShortTimeString()} {o.OrderTime.ToShortDateString()}",
                    Status = o.Status,
                    Dishes = o.Dishes.Select(d => new OrderedDishInfo()
                    {
                        Name = d.Dish.Name,
                        Quantity = d.Quantity
                    }).ToList(),
                    Price = o.Price,
                })
                .ToListAsync();


            return orders;
        }

        public async Task ChangeStatusOrder(Guid orderId, string status)
        {
            var order = await context.Orders
                .FirstOrDefaultAsync(o => o.Id == orderId);

            order.Status = status;

            await context.SaveChangesAsync();
        }

        public async Task<bool> IsOrderExists(Guid orderId)
        {
            return await context.Orders.AnyAsync(o => o.Id == orderId);
        }

        public async Task<bool> IsOrderInRestaurant(Guid orderId, Guid restaurantId)
        {
            var order = await context.Orders
                .FirstOrDefaultAsync(o => o.Id == orderId && o.RestaurantId == restaurantId);

            return order != null;
        }

        public async Task<List<OrderViewModel>> GetOrdersByRestaurantId(Guid restaurantId)
        {
            var orders = await context.Orders
                .Where(o => o.RestaurantId == restaurantId && o.Status != OrderStatus.Delivered.ToString())
                .OrderBy(o => o.OrderTime)
                .Select(o => new OrderViewModel()
                {
                    Id = o.Id,
                    RestaurantName = o.Restaurant.User.Name,
                    DeliveryAddress = o.Address,
                    DeliveryTime = o.DeliveryTime.HasValue ? $"{o.DeliveryTime.Value.ToShortTimeString()} {o.DeliveryTime.Value.ToShortDateString()}" : string.Empty,
                    OrderTime = $"{o.OrderTime.ToShortTimeString()} {o.OrderTime.ToShortDateString()}",
                    Status = o.Status,
                    PhoneNumber = o.Customer.User.PhoneNumber,
                    Dishes = o.Dishes.Select(d => new OrderedDishInfo()
                    {
                        Name = d.Dish.Name,
                        Quantity = d.Quantity
                    }).ToList(),
                    Price = o.Price,
                })
                .ToListAsync();

            return orders;
        }

        public async Task<AcceptOrderFormModel?> GetOrderById(Guid orderId)
        {
            var order = await context.Orders
                .Select(o => new AcceptOrderFormModel()
                {
                    Id = o.Id,
                    CustomerName = o.Customer.User.Name,
                    DeliveryAddress = o.Address,
                    OrderTime = o.OrderTime.ToShortTimeString(),
                    Status = o.Status,
                    Dishes = o.Dishes.Select(d => new OrderedDishInfo()
                    {
                        Name = d.Dish.Name,
                        Quantity = d.Quantity
                    }).ToList(),
                    Price = o.Price,

                })
                .FirstOrDefaultAsync(o => o.Id == orderId);

            return order;
        }

        public async Task AddOrderDeliveryTime(AcceptOrderFormModel model)
        {
            var order = await context.Orders
                .Where(o => o.Id == model.Id)
                .FirstOrDefaultAsync();

            order.DeliveryTime = model.DeliveryTime;

            await context.SaveChangesAsync();
        }

    }
}
