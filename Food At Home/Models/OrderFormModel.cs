using System.ComponentModel.DataAnnotations;

namespace Food_At_Home.Models
{
    public class OrderFormModel
    {
        public OrderFormModel()
        {
            this.DishesForOrder = new List<OrderDishView>();

        }
        [StringLength()]
        public string Address { get; set; } = null!;


        [StringLength()]
        public string City { get; set; }

        public ICollection<OrderDishView> DishesForOrder { get; set; }

        public string RestaurantId { get; set; }

        public string PaymentId { get; set; }
    }
}
