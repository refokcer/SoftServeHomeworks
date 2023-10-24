using Homework9.Homework9.Classes;

namespace TestHomework9;

[TestClass]
public class SquareClassTest
{
    [TestMethod]
    public void Area_12side_144returned()
    {
        // arrange
        var square = new Square("S", 12);
        var expected = 144;

        // actual
        var actual = square.Area();
        
        // Assert
        Assert.IsTrue(actual.Equals(expected));
    }
}