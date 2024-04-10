using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Food_At_Home.Configurations
{
    public class RolesConfiguration: IEntityTypeConfiguration<IdentityRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityRole<Guid>> builder)
        {
            builder.HasData(GetRoles());
        }

        public List<IdentityRole<Guid>> GetRoles()
        {

            return new List<IdentityRole<Guid>>()
            {
                new IdentityRole<Guid>()
                {
                    Id = Guid.Parse("1e1fd1db-4ee5-4933-a51a-ead302e6db41"),
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },

                new IdentityRole <Guid>()
                {
                    Id = Guid.Parse("5534ff36-7149-4ffa-8581-16958c5f7d22"),
                    Name = "Restaurant",
                    NormalizedName = "RESTAURANT"
                },

                new IdentityRole <Guid>()
                {
                    Id = Guid.Parse("d7a6c5ef-dbd7-4e21-bafc-258257e0894f"),
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                }
            };
        }
    }
}
