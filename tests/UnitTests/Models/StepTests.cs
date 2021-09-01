using FluentAssertions;
using NUnit.Framework;
using RecipeApi.Models;

namespace UnitTests.Models
{
    public class StepTests
    {
        [Test]
        public void ShouldCreate()
        {
            var step = new Step();
            step.Should().NotBeNull();
        }
    }
}
