namespace Food_At_Home.Models.Dish
{
    public class PreDeleteDishViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Ingredients { get; set; }

        public string? ImageUrl { get; set; }
    }
}
