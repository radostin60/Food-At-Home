using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Food_At_Home.Configurations
{
    public class RolesConfiguration: IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(GetRoles());
        }

        public List<IdentityRole> GetRoles()
        {

            return new List<IdentityRole>()
            {
                new IdentityRole()
                {
                    Id = "1e1fd1db-4ee5-4933-a51a-ead302e6db41",
                    Name = "Administrator"
                },

                new IdentityRole()
                {
                    Id = "5534ff36-7149-4ffa-8581-16958c5f7d22",
                    Name = "Restaurant"
                },

                new IdentityRole()
                {
                    Id = "d7a6c5ef-dbd7-4e21-bafc-258257e0894f",
                    Name = "Customer"
                }
            };
        }
    }
}
