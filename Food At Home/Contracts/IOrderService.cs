using Food_At_Home.Models.Order;

namespace Food_At_Home.Contracts
{
    public interface IOrderService
    {
        Task<List<Guid>> GetOrdersIdByRestaurantId(Guid restaurantId);

        Task<int> GetOrdersCountByUserId(Guid userId);

        Task<Guid> CreateOrder(OrderFormModel model, Guid userId);

        Task<List<OrderViewModel>> GetOrdersByCustomerId(Guid customerId);

        Task ChangeStatusOrder(Guid orderId, string status);

        Task<bool> IsOrderExists(Guid orderId);

        Task<bool> IsOrderInRestaurant(Guid orderId, Guid restaurantId);

        Task<List<OrderViewModel>> GetOrdersByRestaurantId(Guid restaurantId);

        Task<AcceptOrderFormModel?> GetOrderById(Guid orderId);

        Task AddOrderDeliveryTime(AcceptOrderFormModel model);
    }
}
