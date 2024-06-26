﻿namespace Food_At_Home.Models
{
    public class ProfileViewModel
    {
        public ProfileViewModel()
        {
            this.MenuPhotos = new List<string>();
        }
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string? ProfilePictureUrl { get; set; }

        public bool IsRestaurant { get; set; }

        public string Role { get; set; }

        public List<string> MenuPhotos { get; set; }

        public int OrdersCount { get; set; }
    }
}
