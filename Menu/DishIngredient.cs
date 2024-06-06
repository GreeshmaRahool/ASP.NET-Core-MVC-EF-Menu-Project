using Menu.Models;

namespace Menu
{
    public class DishIngredient
    {
        public int DishId { get; set; }
        public Dish Dish { get; set; }

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        public List<DishIngredient>? DishIngredients { get; set; }
    }
}
