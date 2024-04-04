using Food_At_Home.Contracts;
using Food_At_Home.Data;
using Food_At_Home.Data.Models;
using Food_At_Home.Models;
using Microsoft.EntityFrameworkCore;

namespace Food_At_Home.Services
{
    public class PaymentService: IPaymentService
    {
        private readonly FoodDbContext context;

        public PaymentService(FoodDbContext context)
        {
            this.context = context;
        }

        public async Task<string> CreatePayment(Guid customerId, PaymentFormModel model)
        {
            string[] expiryDate = model.ExpiryDate.Split('/');
            var payment = new Payment()
            {
                Id = Guid.NewGuid(),
                Amount = model.Amount,
                CardHolder = model.CardHolder,
                CardNumber = model.CardNumber,
                CustomerId = customerId,
                ExpiryDate = DateTime.Parse($"01/{expiryDate[0]}/20{expiryDate[1]}"),
                SecurityCode = model.SecurityCode
            };

            await context.AddAsync(payment);
            await context.SaveChangesAsync();

            return payment.Id.ToString();
        }

        public async Task AddPaymentOrderId(Guid paymentId, Guid orderId)
        {
            var payment = await context.Payments
                .FirstOrDefaultAsync(p => p.Id == paymentId);

            payment.OrderId = orderId;

            await context.SaveChangesAsync();
        }
    }
}
