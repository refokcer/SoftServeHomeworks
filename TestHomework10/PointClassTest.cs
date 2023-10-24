using Homework10.Homework10_1;

namespace TestHomework10;

[TestClass]
public class PointClassTest
{
    [TestMethod]
    public void Distant_5and15to0and0_15d811returned()
    {
        var x = new Point(5, 15);
        var y = new Point(0, 0);
        var expected = 15.811388300841896;

        var actual = x.Distance(y);

        Assert.IsTrue(expected.Equals(actual));
    }
}