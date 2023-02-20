namespace ShapeLibrary.Tests;

[TestClass]
public class TriangleTest
{
    [TestMethod]
    public void ExceptionTest()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(()
            => { new Triangle(-1, 3, 4); });
        Assert.ThrowsException<ArgumentOutOfRangeException>(()
            => { new Triangle(2, 3, 15); });
    }

    [TestMethod]
    public void CreateTest()
    {
        double a = 10D;
        double b = 10D;
        double c = 10D;
        var shape = new Triangle(a, b, c);
        Assert.IsNotNull(shape);
    }


    [TestMethod]
    public void SideTest()
    {
        double a = 10D;
        double b = 11D;
        double c = 12D;
        
        var shape = new Triangle(a, b, c);
        
        Assert.AreEqual(a, shape.Sides.A);
        Assert.AreEqual(b, shape.Sides.B);
        Assert.AreEqual(c, shape.Sides.C);
    }


    [TestMethod]
    public void AreaTest()
    {
        double a = 3D;
        double b = 4D;
        double c = 5D;
        double area = 6D;

        var shape = new Triangle(a, b, c);
        
        Assert.AreEqual(area, shape.Area);
    }

    [TestMethod]
    public void IsRightTest()
    {
        double a = 3D;
        double b = 4D;
        double c = 5D;

        var shape = new Triangle(a, b, c);

        Assert.IsTrue(shape.IsRightAngle);
    }

    [TestMethod]
    public void IsNotRightTest()
    {
        double a = 3D;
        double b = 4D;
        double c = 7D;

        var shape = new Triangle(a, b, c);

        Assert.IsFalse(shape.IsRightAngle);
    }
}