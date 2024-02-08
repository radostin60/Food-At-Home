using Food_At_Home.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Food_At_Home.Data
{
    public class FoodDbContext : IdentityDbContext<User>
    {
        public FoodDbContext(DbContextOptions<FoodDbContext> options)
            : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
            .Property(x => x.UserName)
            .HasMaxLength(20)
            .IsRequired();

            builder.Entity<User>()
            .Property(x => x.Email)
            .HasMaxLength(60)
            .IsRequired();

            builder.Entity<User>()
            .Property(x => x.PhoneNumber)
            .HasMaxLength(20)
            .IsRequired();

            base.OnModelCreating(builder);
        }
    }
}