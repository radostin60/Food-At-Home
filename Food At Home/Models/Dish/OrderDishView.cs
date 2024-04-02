namespace Food_At_Home.Models.Dish
{
    public class OrderDishView
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }

        public string? Ingredients { get; set; }

        public string? ImageUrl { get; set; }

        public int Quantity { get; set; }

        public decimal? Price { get; set; }

        public Guid? RestaurantId { get; set; }

        //public bool IsEnabled { get; set; } = true;
    }
}
