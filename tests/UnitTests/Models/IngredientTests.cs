using FluentAssertions;
using NUnit.Framework;
using RecipeApi.Models;

namespace UnitTests.Models
{
    public class IngredientTests
    {
        [Test]
        public void ShouldCreate()
        {
            var ingredient = new Ingredient();
            ingredient.Should().NotBeNull();
        }
    }
}
