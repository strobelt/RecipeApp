using Bogus;
using FluentAssertions;
using NUnit.Framework;
using RecipeApi.Models;

namespace UnitTests.Models
{
    public class RecipeTests
    {
        [Test]
        public void ShouldCreateWithTitle()
        {
            var expectedTitle = new Faker().Lorem.Sentence(2);
            var recipe = new Recipe(expectedTitle);
            recipe.Should().NotBeNull();
        }
    }
}