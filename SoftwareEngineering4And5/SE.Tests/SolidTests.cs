namespace SE.Tests;

public class SolidTests
{
    [Fact]
    public void CalculateSquarePlusHalf_Return_105_given_10()
    {
        // Arrange

        // Act
        var actual = Solid.CalculateSquarePlusHalf(10);

        // Assert
        actual.Should().Be(105);

    }
    
    [Fact]
    public void CalculateSquarePlusHalf_and_CalculateSquare_with_PlusHalf_returns_the_same()
    {
        int x = 10;
        var old = Solid.CalculateSquarePlusHalf(x);
        var refactored = Solid.CalculateSquare(x) + Solid.CalculateHalf(x);

        old.Should().Be(refactored);
    }
}