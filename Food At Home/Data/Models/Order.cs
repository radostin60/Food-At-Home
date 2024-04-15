using Food_At_Home.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food_At_Home.Data.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [EnumDataType(typeof(OrderStatus))]
        public string Status { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string Address { get; set; } = null!;
 
        [Required]
        [ForeignKey(nameof(Restaurant))]
        public Guid RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; } = null!;

        [Required]
        public DateTime OrderTime { get; set; }

        public DateTime? DeliveryTime { get; set; }

        [Required]
        [Precision(18,2)]
        public decimal Price { get; set; }

        [ForeignKey(nameof(Payment))]
        public Guid? PaymentId { get; set; }

        public Payment? Payment { get; set; }

        [Required]
        [ForeignKey(nameof(Customer))]
        public Guid CustomerId { get; set; } 

        public Customer Customer { get; set; } = null!;

        public virtual ICollection<OrderDish> Dishes { get; set; } = null!;


    }
}
