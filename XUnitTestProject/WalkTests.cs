using FluentAssertions;
using TheWalkKata;
using Xunit;

namespace XUnitTestProject
{
    public class WalkTests
    {
        [Fact]
        public void AreWalksValid()
        {
            Kata.IsValidWalk(new[] {"n", "s", "n", "s", "n", "s", "n", "s", "n", "s"}).Should().BeTrue();
            Kata.IsValidWalk(new[] {"w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e"}).Should().BeFalse();
            Kata.IsValidWalk(new[] {"w"}).Should().BeFalse();
            Kata.IsValidWalk(new[] {"n", "n", "n", "s", "n", "s", "n", "s", "n", "s"}).Should().BeFalse();
        }
    }
}