namespace Food_At_Home.Models.Dish
{
    public class DishViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Ingredients { get; set; }

        public decimal Price { get; set; }

        public string DishImageUrl { get; set; }

        public Guid RestaurantUserId { get; set; }
    }
}
