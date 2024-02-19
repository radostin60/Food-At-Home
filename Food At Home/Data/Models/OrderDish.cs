using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food_At_Home.Data.Models
{
    public class OrderDish
    {
        [Required]
        [ForeignKey(nameof(Dish))]
        public Guid DishId { get; set; }
        public Dish Dish { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Order))]
        public Guid OrderId { get; set; }
        public Order Order { get; set; } = null!;

        public int Quantity { get; set; }
    }
}
