using System.Collections.Generic;

namespace RecipeApi.Models
{
    public class Recipe
    {
        public string Title { get; set; }
        public int TotalTime { get; set; }

        public IList<Ingredient> Ingredients { get; } = new List<Ingredient>();
        public List<Step> Steps { get; } = new List<Step>();

        public Recipe(string title) => Title = title;

        public void AddIngredient(Ingredient ingredient) => Ingredients.Add(ingredient);
        public void AddStep(Step step) => Steps.Add(step);
    }
}
