using Bogus;
using FluentAssertions;
using NUnit.Framework;
using RecipeModels;
using UnitTests.Builders;

namespace UnitTests.Models
{
    public class RecipeTests
    {
        private string expectedTitle;
        private Recipe recipe;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            expectedTitle = new Faker().Lorem.Sentence(2);
            recipe = new Recipe(expectedTitle);
        }

        [Test]
        public void ShouldCreateWithTitle() => recipe.Should().NotBeNull();

        [Test]
        public void ShouldAddAnIngredient()
        {
            var expectedIngredient = new IngredientBuilder().Generate();
            recipe.AddIngredient(expectedIngredient);

            recipe.Ingredients.Should().Contain(expectedIngredient);
        }

        [Test]
        public void ShouldAddAnStep()
        {
            var expectedStep = new StepBuilder().Generate();
            recipe.AddStep(expectedStep);

            recipe.Steps.Should().Contain(expectedStep);
        }
    }
}
