namespace ShapeLibrary;

/// <summary>
/// Класс Треугольник
/// </summary>
public class Triangle : ShapeBase
{
    /// <summary>
    /// Поле для хранения размеров сторон
    /// </summary>
    private (double a, double b, double c) _sides;
    
    /// <summary>
    /// Длины сторон
    /// </summary>
    public (double A, double B, double C) Sides
    { 
        get => _sides;
        set 
        {
            if(value.A < 0 || value.B < 0 || value.C < 0
                || value.A > value.B + value.C 
                || value.B > value.A + value.C
                || value.C > value.A + value.B) 
                throw new ArgumentOutOfRangeException(nameof(value));
            _sides = value;
        }
    }

    /// <summary>
    /// Прямоугольный треугольник?
    /// </summary>
    public bool IsRightAngle
    {
        get 
        {
            return Sides.A * Sides.A == Sides.B * Sides.B + Sides.C * Sides.C
                || Sides.B * Sides.B == Sides.A * Sides.A + Sides.C * Sides.C
                || Sides.C * Sides.C == Sides.B * Sides.B + Sides.A * Sides.A;
        }
    }

    /// <summary>
    /// Площадь треугольника
    /// </summary>
    public override double Area
    {
        get
        {
            double heron = (Sides.A + Sides.B + Sides.C) / 2;
            double area = Math.Sqrt(heron * (heron - Sides.A) 
                                          * (heron - Sides.B) 
                                          * (heron - Sides.C));                       
            return area;                                           
        }
    }

    /// <summary>
    /// Треугольник
    /// </summary>
    /// <param name="a">Длина стороны A</param>
    /// <param name="b">Длина стороны B</param>
    /// <param name="c">Длина стороны C</param>
    public Triangle(double a, double b, double c) => Sides = (a, b, c);

    /// <summary>
    /// Текстовое представление
    /// </summary>
    /// <returns>Описание треугольника</returns>
    public override string ToString() => $"Треугольник со сторонами ({Sides.A}, {Sides.B}, {Sides.C}){(IsRightAngle ? " " : " не ")} является прямоугольным и имеет площадь {Area:0.##}.";
}
