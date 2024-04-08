namespace Food_At_Home.Models.Dish
{
    public class AllDishesFilteredAndPages
    {
        public AllDishesFilteredAndPages()
        {
            this.Dishes = new HashSet<DishViewModel>();
        }

        public int TotalDishes { get; set; }

        public IEnumerable<DishViewModel> Dishes { get; set; }
    }
}
