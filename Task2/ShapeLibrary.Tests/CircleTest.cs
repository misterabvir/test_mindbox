namespace ShapeLibrary.Tests;

[TestClass]
public class CircleTest
{
    [TestMethod]
    public void ExceptionTest()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() 
            => { new Circle(-1); });
    }

    [TestMethod]
    public void CreateTest()
    {
        double radius = 100D;
        var shape = new Circle(radius);
        Assert.IsNotNull(shape);
    }

    [TestMethod]
    public void RadiusTest()
    {
        double radius = 100D;
        var shape = new Circle(radius);
        Assert.IsNotNull(shape);
        Assert.AreEqual(radius, shape.Radius);
    }

    [TestMethod]
    public void AreaTest()
    {
        double radius = 1D;
        var shape = new Circle(radius);
        Assert.IsNotNull(shape);
        Assert.AreEqual(Math.PI, shape.Area);
    }
}