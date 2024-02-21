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


        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Dish> Dishes { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderDish> OrderDishes { get; set; } = null!;
        public DbSet<Payment> Payments { get; set; } = null!;
        public DbSet<Restaurant> Restaurants { get; set; } = null!;


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