using Food_At_Home.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Food_At_Home.Configurations
{
    public class UserConfiguration: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(CreateUsers());
        }

        public List<User> CreateUsers()
        {
            List<User> users = new List<User>();
            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();

            var user = new User()
            {
                Id = Guid.Parse("2341fe11-cd36-40c1-b5e4-5c5831ee501d"),
                UserName = "radostin1",
                Email = "radostin1@abv.bg",
                PhoneNumber = "0887399847",
                Name = "Radostin Dimitrov",
                City = "Kazanlak",
                Address = "Mazalat 16",
                ImageUrl = ""
            };
        }

    }
}
