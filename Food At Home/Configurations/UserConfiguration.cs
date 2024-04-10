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
                NormalizedUserName = "RADOSTIN1",
                Email = "radostin1@abv.bg",
                NormalizedEmail = "RADOSTIN1@ABV.BG",
                PhoneNumber = "0877311440",
                Name = "Radostin Dimitrov",
                City = "Kazanlak",
                Address = "Mazalat 16",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ImageUrl = ""
            };

            user.PasswordHash = passwordHasher.HashPassword(user, "12345678");
            users.Add(user);

            var user2 = new User()
            {
                Id = Guid.Parse("b7892962-0426-48de-bd62-8ca55ebe930e"),
                UserName = "dominos",
                NormalizedUserName = "DOMINOS",
                Email = "dominos@abv.bg",
                NormalizedEmail ="DOMINOS@ABV.BG",
                PhoneNumber = "0882759837",
                Name = "Domino's Pizza",
                City = "Kazanlak",
                Address = "Al. Batenberg 46",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ImageUrl = ""
            };

            user2.PasswordHash = passwordHasher.HashPassword(user2, "11111111");
            users.Add(user2);

            var user3 = new User()
            {
                Id = Guid.Parse("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"),
                UserName = "admin",
                NormalizedUserName ="ADMIN",
                Email = "admin@abv.bg",
                NormalizedEmail ="ADMIN@ABV.BG",
                PhoneNumber = "0891231234",
                Name = "Admin Account",
                City = "Kazanlak",
                Address = "6-ti Septemvri 9",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ImageUrl = ""
            };

            user3.PasswordHash = passwordHasher.HashPassword(user3, "22222222");
            users.Add(user3);

            return users;

        }

       

    }
}
