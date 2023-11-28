using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipeManager
{
    public class RecipeDB
    {

        //https://www.codeproject.com/Tips/825532/Read-Insert-Data-Using-Stored-Procedures-in-Csharp
        int RecipeID { get; set; }
        string RecipeName { get; set; }
        string Type { get; set; }
        string Author { get; set; }
        int Rating {  get; set; }
        string Ingredients { get; set; }
        public RecipeDB (int RecipeID, string RecipeName, string Type, string Author, int Rating, string Ingredients)
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
