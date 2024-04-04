using Food_At_Home.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Food_At_Home.Configurations
{
    public class CustomerConfiguration: IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(new Customer()
            {
                Id = Guid.Parse("5646fe32-cf59-45db-b27d-9ddb76d0b8d6"),
                UserId = Guid.Parse("2341fe11-cd36-40c1-b5e4-5c5831ee501d")
            });
        }
    }
}
