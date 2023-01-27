using ShapeLibrary;

using System;

namespace ShapeConsole;
public class Program
{
    static void Main()
    {
        
        List<ShapeBase> list = new List<ShapeBase>();

        list.Add(new Circle(radius: 5));
        list.Add(new Circle(radius: 3));
        list.Add(new Circle(radius: 4));

        list.Add(new Triangle(sideA: 3, sideB: 4, sideC: 5));
        list.Add(new Triangle(sideA: 3, sideB: 4, sideC: 6));
        list.Add(new Triangle(sideA: 6, sideB: 8, sideC: 5));

        foreach (var shape in list)
        {
            Console.WriteLine($"Square of the {shape.ShapeIs()} is {shape.Square():#.00000}");
        }

        var triangle = new Triangle(sideA: 3, sideB: 4, sideC: 5);
        Console.WriteLine($"{triangle}. Is it right triangle: {triangle.IsRight}"); //true
        triangle = new Triangle(sideA: 3, sideB: 4, sideC: 6);
        Console.WriteLine($"{triangle}. Is it right triangle: {triangle.IsRight}"); //false
    }
}



