using Food_At_Home.Models;

namespace Food_At_Home.Contracts
{
    public interface IPaymentService
    {
        Task<Guid> CreatePayment(Guid customerId, PaymentFormModel model);

        Task AddPaymentOrderId(Guid paymentId, Guid orderId);
    }
}
