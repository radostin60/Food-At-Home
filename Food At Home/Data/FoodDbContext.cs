using Food_At_Home.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Food_At_Home.Data
{
    public class FoodDbContext : IdentityDbContext<User,IdentityRole<Guid>, Guid>
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

            builder.Entity<OrderDish>()
                .HasKey(od => new { od.OrderId, od.DishId});

            //builder.Entity<Restaurant>()
            //    .HasMany(o => o.Orders)
            //    .WithOne(r => r.Restaurant);

            //builder.Entity<Restaurant>()
            //    .HasMany(m => m.Menu)
            //    .WithOne(r => r.Restaurant);

            builder.Entity<Restaurant>()
                .Property(x => x.Description)
                .HasColumnType("nvarchar")
                .HasMaxLength(600);

            //builder.Entity<Order>()
            //    .HasOne(r => r.Restaurant)
            //    .WithMany(o => o.Orders);

            //builder.Entity<Order>()
            //    .HasMany(d => d.Dishes)
            //    .WithOne(o => o.Order);

            //builder.Entity<Order>()



      

            base.OnModelCreating(builder);


        }
    }
}