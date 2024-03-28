using Food_At_Home.Models.Order;

namespace Food_At_Home.Contracts
{
    public interface IOrderService
    {
        Task<List<string>> GetOrdersIdByRestaurantId(string restaurantId);

        Task<int> GetOrdersCountByUserId(string userId);

        Task<string> CreateOrder(OrderFormModel model, string userId);

        Task<List<OrderViewModel>> GetOrdersByCustomerId(string customerId);

        Task ChangeStatusOrder(string orderId, string status);
    }
}
