using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeBook.Data.Model
{

    public enum RecipeCourse
    {
        Appetizer,
        First,
        Second,
        Dessert
    }

    public class Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecipeId { get; set; }

        public string RecipeName { get; set; }

        public string RecipeDescription { get; set; }

        public string RecipeProcedure { get; set; }

        public int RecipeTime { get; set; }

        public int RecipeCookingTime { get; set; }

        public string RecipeCookingTimeMeasurementUnit { get; set; }

        public int Difficulty { get; set; }

        public int Portions { get; set; }

        public RecipeCourse RecipeCourse { get; set; }

        public List<Ingredient> Ingredients { get; set; }
    }

    public class Ingredient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IngredientId { get; set; }

        public string Name { get; set; }

        public double Quantity { get; set; }

        public string MeasurementUnit { get; set; }

        public bool ToTaste { get; set; }
    }
}
