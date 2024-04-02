using Food_At_Home.Contracts;
using Food_At_Home.Data;
using Food_At_Home.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Food_At_Home.Services
{
    public class CustomerService: ICustomerService
    {
        private readonly FoodDbContext context;

        public CustomerService(FoodDbContext context)
        {
            this.context = context;
        }

        public async Task Create(Guid userId)
        {
            var customer = new Customer()
            {
                UserId = userId,
            };

            await context.AddAsync(customer);
            await context.SaveChangesAsync();

        }

        public async Task<Guid?> GetCustomerId(Guid userId)
        {
            return await context.Customers
                .Where(c =>c.Id == userId || c.UserId == userId)
                .Select(c => c.Id)
                .FirstOrDefaultAsync();
        }
    }
}
