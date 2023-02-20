using ShapeLibrary;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

List<ShapeBase> shapes = new List<ShapeBase>();
shapes.Add(new Circle(3.2));
shapes.Add(new Circle(14));
shapes.Add(new Triangle(4, 5, 6));
shapes.Add(new Circle(8.5));
shapes.Add(new Triangle(10, 6, 8));

foreach (var shape in shapes)
{
    Console.WriteLine($"{shape.ToString()}");
    Console.WriteLine(shape.Area);
}
