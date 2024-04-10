using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Food_At_Home.Configurations
{
    public class UserRolesConfiguration: IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            builder.HasData(GetUserRoles());
        }

        public List<IdentityUserRole<Guid>> GetUserRoles()
        {
            return new List<IdentityUserRole<Guid>>(){

                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("1e1fd1db-4ee5-4933-a51a-ead302e6db41"),
                    UserId = Guid.Parse("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71")
                },
                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("d7a6c5ef-dbd7-4e21-bafc-258257e0894f"),
                    UserId =  Guid.Parse("2341fe11-cd36-40c1-b5e4-5c5831ee501d")
                },
                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("5534ff36-7149-4ffa-8581-16958c5f7d22"),
                    UserId = Guid.Parse("b7892962-0426-48de-bd62-8ca55ebe930e")
                }

            };
        }


    }
}
