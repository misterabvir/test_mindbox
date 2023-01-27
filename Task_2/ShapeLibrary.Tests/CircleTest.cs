namespace ShapeLibrary.Tests;

[TestClass]
public class CircleTest
{
    [TestMethod]
    public void CircleRadiusTest()
    {
        double radius = 10.0D;
        for (int i = 10; i < 100000; i*=10)
        {
            Circle circle = new Circle(radius);
            Assert.AreEqual(radius, circle.Radius);
        }
    }
    
    [TestMethod]
    public void CircleLengthTest()
    {
        double radius = 10.0D;
        for (int i = 10; i < 100000; i*=10)
        {
            Circle circle = new Circle(radius);
            Assert.AreEqual(2 * Math.PI * radius, circle.CircleLength);
        }
    }

    [TestMethod]
    public void CircleDiameterTest()
    {
        double radius = 10.0D;
        for (int i = 10; i < 100000; i*=10)
        {
            Circle circle = new Circle(radius);
            Assert.AreEqual(radius + radius, circle.Diameter);
        }
    }

    [TestMethod]
    public void CircleSquareTest()
    {
        double radius = 10.0D;
        for (int i = 10; i < 100000; i*=10)
        {
            Circle circle = new Circle(radius);
            Assert.AreEqual(Math.PI * radius * radius, circle.Square);
        }
    }
}