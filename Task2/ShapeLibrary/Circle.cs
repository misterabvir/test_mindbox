namespace ShapeLibrary;

/// <summary>
/// Класс КРУГ
/// </summary>
public class Circle : ShapeBase
{
    /// <summary>
    /// Поле для хранения радиуса
    /// </summary>
    private double _radius;
    
    /// <summary>
    /// Радиус круга
    /// </summary>
    public double Radius
    { 
        get => _radius;
        set
        { 
            if(value < 0) throw new ArgumentOutOfRangeException(nameof(value));
            _radius = value;
        }
    }

    /// <summary>
    /// Получить площадь круга
    /// </summary>
    public override double Area => Math.PI * Radius * Radius;

    /// <summary>
    /// Круг
    /// </summary>
    /// <param name="radius">Задать радиус</param>
    public Circle(double radius) => Radius = radius;

    /// <summary>
    /// Текстовое представление
    /// </summary>
    /// <returns>Описание круга</returns>
    public override string ToString() => $"Круг с радиусом {Radius} имеет площадь {Area:0.##}.";
}
