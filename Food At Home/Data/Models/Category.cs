using System.ComponentModel.DataAnnotations;

namespace Food_At_Home.Data.Models
{
    public class Category
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public ICollection<Dish> Dishes { get; set; } = null!;
    }
}
