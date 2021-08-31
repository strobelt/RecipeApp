using System.Collections.Generic;

namespace RecipeApi.Models
{
    public class Recipe
    {
        public string Title { get; set; }
        public int TotalTime { get; set; }

        public IList<Ingredient> Ingredients { get; private set; }

        public Recipe(string title) => Title = title;

        public void AddIngredient(Ingredient ingredient) => Ingredients.Add(ingredient);
    }
}