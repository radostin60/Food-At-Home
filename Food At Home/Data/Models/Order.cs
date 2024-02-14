using Food_At_Home.Data.Models.Enums;
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
        public string Status { get; set; }

        [Required]
        [ForeignKey(nameof(Restaurant))]
        public Guid RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        [Required]
        public DateTime OrderTime { get; set; }

        [Required]
        public DateTime DeliveryTime { get; set; }


    }
}
