using Food_At_Home.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Food_At_Home.Models.Dish
{
    public class DishesQueryModel
    {
        public DishesQueryModel()
        {
            this.CurrentPage = 1;
            this.DishesPerPage = 3;

            this.Categories = new HashSet<string>();
            this.Dishes = new HashSet<DishViewModel>();

        }
        public string? Category { get; set; }

        [Display(Name = "Sort Dishes By")]
        public DishSorting DishSorting { get; set; }

        public int CurrentPage { get; set; }

        [Display(Name = "Dishes Per Page")]
        public int DishesPerPage { get; set; }

        public int TotalDishes { get; set; }

        public IEnumerable<string> Categories { get; set; }

        public IEnumerable<DishViewModel> Dishes { get; set; }
    }
}
