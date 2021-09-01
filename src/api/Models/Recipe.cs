using System.Collections.Generic;

namespace RecipeApi.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TotalTime { get; set; }

        public IList<RecipeIngredient> Ingredients { get; } = new List<RecipeIngredient>();
        public List<Step> Steps { get; } = new List<Step>();

        public Recipe(string title) => Title = title;

        public void AddIngredient(RecipeIngredient ingredient) => Ingredients.Add(ingredient);
        public void AddStep(Step step) => Steps.Add(step);
    }
}
