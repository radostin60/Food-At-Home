﻿using Food_At_Home.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Food_At_Home.Configurations
{
    public class RestaurantConfiguration: IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.HasData(new Restaurant()
            {
                Id = Guid.Parse("ce604d6e-1a66-4059-9777-388cbc34ef84"),
                UserId = ,
                Description = "Welcome to Food At Home! Where every meal is a journey of flavors and every moment is savored. We're delighted to have you dine with us today. Sit back, relax, and get ready to indulge in culinary delights crafted just for you. Enjoy your time with us!"
            });
        }
    }
}
