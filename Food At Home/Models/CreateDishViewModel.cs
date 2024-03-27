using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Food_At_Home.Models
{
    public class CreateDishViewModel
    {
        public CreateDishViewModel()
        {
            this.Categories = new List<DishCategoryModel>();
        }

        [Required]
        [StringLength(20)]
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Ingredients { get; set; } = null!;

        public IFormFile? ImageUrl { get; set; }

        [Precision(18, 2)]
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        [Display(Name = "Category")]
        public Guid CategoryId { get; set; }

        public IEnumerable<DishCategoryModel> Categories { get; set; }
    }
}
