using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipeManager
{
    public class RecipeDB
    {
        public int RecipeID { get; set; }
        public string? RecipeName { get; set; }
        public string? Type { get; set; }
        public string? Author { get; set; }
        public int Rating {  get; set; }
        public string? Ingredients { get; set; }

        public RecipeDB (int RecipeID, string? RecipeName, string? Type, string? Author, int Rating, string? Ingredients)
        {
            this.RecipeID = RecipeID;
            this.RecipeName = RecipeName;
            this.Type = Type;
            this.Author = Author;
            this.Rating = Rating;
            this.Ingredients = Ingredients;
        }
    }
}
