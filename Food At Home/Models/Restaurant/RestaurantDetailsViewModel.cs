namespace Food_At_Home.Models.Restaurant
{
    public class RestaurantDetailsViewModel
    {
        public Guid Id { get; set; }

        public string? ImageUrl { get; set; }

        public string? Description { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

    }
}
