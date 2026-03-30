namespace Tests;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    /*
- should encapsulate the variables and methods within a `Rectangle` class
- should pass the variables into the `Rectangle` as constructor arguments
- should have a `CalculateArea` method that takes no arguments
    */

    [Fact]
    public void Should_Encapsulate_The_Variables_And_Methods_Within_A_Rectangle_Class(){
        var rectangle = new Rectangle(3, 4);

        Assert.Equal(12, rectangle.CalculateArea());
    }

    [Fact]
    public void Should_Pass_The_Variables_Into_The_Rectangle_As_Constructor_Arguments(){
        var rectangle = new Rectangle(3, 4);

        Assert.True(rectangle != null);
    }

    [Fact]
    public void Should_Have_A_CalculateArea_Method_That_Takes_No_Arguments(){
        var rectangle = new Rectangle(3, 4);

        Assert.Equal(12, rectangle.CalculateArea());
    }
}