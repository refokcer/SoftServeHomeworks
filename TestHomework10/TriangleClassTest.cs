using Homework10.Homework10_1;

namespace TestHomework10;

[TestClass]
public class TriangleClassTest
{
    [TestMethod]
    public void Square_AandBandC_CorrectSquareReturned()
    {
        // Arrange
        var a = new Point(10, 15);
        var b = new Point(-5, 45);
        var c = new Point(0, 5);
        
        var triangle = new Triangle(a, b, c);
        
        var expectedSquare = 224.99999999999983;

        // Actual
        var actualSquare = triangle.Square();

        // Assert
        Assert.IsTrue(expectedSquare.Equals(actualSquare));
    }
    
    [TestMethod]
    public void Perimeter_AandBandC_CorrectPerimeterReturned()
    {
        // Arrange
        var a = new Point(10, 15);
        var b = new Point(-5, 45);
        var c = new Point(0, 5);

        var triangle = new Triangle(a, b, c);

        var expectedPerimeter = 87.99444402772053;

        // Actual
        var actualPerimeter = triangle.Perimeter();

        // Assert
        Assert.IsTrue(expectedPerimeter.Equals(actualPerimeter));
    }
}