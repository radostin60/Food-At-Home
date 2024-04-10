using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food_At_Home.Data.Models
{
    public class Dish
    {
        public Dish()
        {
            this.Orders = new List<OrderDish>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Ingredients { get; set; } = null!;
        public string? Description { get; set; }

        [Required]
        [Precision(18,2)]
        public decimal  Price { get; set; }

        public string ImageUrl { get; set; } = null!;

        [ForeignKey(nameof(Restaurant))]
        public Guid RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; } = null!;

        public int Quantity { get; set; }


        public ICollection<OrderDish> Orders { get; set; }

    }
}
