using Food_At_Home.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Food_At_Home.Configurations
{
    public class CategoryConfiguration: IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(GetCategories());
        }

        public List<Category> GetCategories() 
        {
            List<Category> categories = new List<Category>();

            categories.Add(new Category
            {
                Id = Guid.Parse("e4f042b4-52d4-43fc-bfb2-53102b11b719"),
                Name = "Appetizers"
            }); ;

            categories.Add(new Category
            {
                Id = Guid.Parse("cbc7df0c-83f8-4ccd-acc8-d0bea62d0b33"),
                Name = "Pizzas"
            }); ;

            categories.Add(new Category
            {
                Id = Guid.Parse("87f0373e-6d3d-468d-8989-9894937d6517"),
                Name = "Burgers"
            }); ;
            categories.Add(new Category
            {
                Id = Guid.Parse("adf04d8f-4d96-4180-a7cd-19053a23bc81"),
                Name = "Salads"
            }); ;
            categories.Add(new Category
            {
                Id = Guid.Parse("c0a8af9e-feaf-46d6-92e7-5f44592947e0"),
                Name = "Drinks"
            }); ;
            categories.Add(new Category
            {
                Id = Guid.Parse("5c769ba4-1b92-496d-b18d-2bbde73e6ba1"),
                Name = "Desserts"
            }); ;

            return categories;
        }
    }
}
