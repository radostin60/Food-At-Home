using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Food_At_Home.Configurations
{
    public class UserRolesConfiguration: IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(GetUserRoles());
        }

        public List<IdentityUserRole<string>> GetUserRoles()
        {
            return new List<IdentityUserRole<string>>(){

                new IdentityUserRole<string>()
                {
                    RoleId = "1e1fd1db-4ee5-4933-a51a-ead302e6db41",
                    UserId = "1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"
                },
                new IdentityUserRole<string>()
                {
                    RoleId = "d7a6c5ef-dbd7-4e21-bafc-258257e0894f",
                    UserId =  "2341fe11-cd36-40c1-b5e4-5c5831ee501d"
                },
                new IdentityUserRole<string>()
                {
                    RoleId = "5534ff36-7149-4ffa-8581-16958c5f7d22",
                    UserId = "b7892962-0426-48de-bd62-8ca55ebe930e"
                }

            };
        }


    }
}
