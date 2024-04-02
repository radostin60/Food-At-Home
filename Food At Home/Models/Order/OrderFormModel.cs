using Food_At_Home.Models.Dish;
using System.ComponentModel.DataAnnotations;

namespace Food_At_Home.Models.Order
{
    public class OrderFormModel
    {
        public OrderFormModel()
        {
            DishesForOrder = new List<OrderDishView>();

        }
        [StringLength(60)]
        public string Address { get; set; } = null!;


        [StringLength(20)]
        public string City { get; set; }

        public ICollection<OrderDishView> DishesForOrder { get; set; }

        public Guid RestaurantId { get; set; }

        public Guid PaymentId { get; set; }
    }
}
