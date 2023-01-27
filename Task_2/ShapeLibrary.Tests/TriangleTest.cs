namespace ShapeLibrary.Tests;

[TestClass]
public class TriangleTest
{
    [TestMethod]
    public void TriangleSideTest()
    {
        System.Random rand = new System.Random();
        rand.NextDouble();
        for (int i = 1; i < 10; i++)
        {
            double a = rand.NextDouble() * i;
            double b = rand.NextDouble() * i;
            double c = rand.NextDouble() * i;

            Triangle triangle = new Triangle(a, b, c);
            Assert.AreEqual(a, triangle.A);
            Assert.AreEqual(b, triangle.B);
            Assert.AreEqual(c, triangle.C);
        }
    }

    [TestMethod]
    public void TriangleIsPossibleTest()
    {
        Assert.IsFalse(new Triangle(2, 3, 10).IsPossible);
        Assert.IsFalse(new Triangle(1, 10, 4).IsPossible);
        Assert.IsFalse(new Triangle(20, 3, 10).IsPossible);
        
        Assert.IsTrue(new Triangle(4, 3, 2).IsPossible);
        Assert.IsTrue(new Triangle(4, 5, 6).IsPossible);
        Assert.IsTrue(new Triangle(7, 8, 9).IsPossible);
    }

    [TestMethod]
    public void TriangleIsRightTest()
    {
        Assert.IsFalse(new Triangle(4, 3, 2).IsRight);
        Assert.IsFalse(new Triangle(6, 3, 5).IsRight);
        Assert.IsFalse(new Triangle(4, 3, 7).IsRight);
        
        Assert.IsTrue(new Triangle(4, 3, 5).IsRight);
        Assert.IsTrue(new Triangle(8, 10, 6).IsRight);
        Assert.IsTrue(new Triangle(12, 5, 13).IsRight);
    }
    [TestMethod]
    public void TrianglePerimeterTest()
    {
        Assert.AreEqual(4 + 3 + 2, new Triangle(4, 3, 2).Perimeter);
        Assert.AreEqual(5 + 6 + 7, new Triangle(5, 6, 7).Perimeter);
        Assert.AreEqual(8 + 9 + 2, new Triangle(8, 9, 2).Perimeter);
    }

    [TestMethod]
    public void TriangleSquareTest()
    {
        // SQRT(5 * 1 * 2 * 2) = 4.47214
        Assert.AreEqual(4.47214, Math.Round(new Triangle(4, 3, 3).Square, 5));

        // SQRT(9 * 4 * 3 * 2) = 14.69694
        Assert.AreEqual(14.69694, Math.Round(new Triangle(5, 6, 7).Square, 5));
        
        // SQRT(9.5 * 1.5 * 0.5 * 7.5) = 7.31009
        Assert.AreEqual(7.31010, Math.Round(new Triangle(8, 9, 2).Square, 5));
    }
}