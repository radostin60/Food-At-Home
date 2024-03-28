using Food_At_Home.Models;

namespace Food_At_Home.Contracts
{
    public interface IPaymentService
    {
        Task<string> CreatePayment(string customerId, PaymentFormModel model);

        Task AddPaymentOrderId(string paymentId, string orderId);
    }
}
