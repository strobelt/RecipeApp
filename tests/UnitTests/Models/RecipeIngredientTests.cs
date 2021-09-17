using FluentAssertions;
using NUnit.Framework;
using RecipeModels;

namespace UnitTests.Models
{
    public class RecipeIngredientTests
    {
        [Test]
        public void ShouldCreate()
        {
            var ingredient = new RecipeIngredient();
            ingredient.Should().NotBeNull();
        }
    }
}
