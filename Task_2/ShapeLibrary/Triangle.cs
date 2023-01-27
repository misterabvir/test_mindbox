using System.Linq;
namespace ShapeLibrary;

///<summary>Class of triangles</summary>
public class Triangle : ShapeBase
{
    ///<summary>What is this?</summary>
    public override ShapeKind ShapeIs()
    {
        return ShapeKind.triangle;
    }
    
    ///<summary>Size of side A</summary>
    public double A { get; set; }
    
    ///<summary>Size of side B</summary>
    public double B { get; set; }
    
    ///<summary>Size of side C</summary>
    public double C { get; set; }

    ///<summary>Perimeter triangle</summary>
    public double Perimeter => (A + B + C);

    ///<summary>HeronValue</summary>
    private double _heronP => Perimeter / 2;

    ///<summary>Square triangle</summary>
    public override double Square() => 
        Math.Sqrt(_heronP * (_heronP - A) * (_heronP - B) * (_heronP - C));
    
    ///<summary>Is it right triangle</summary>
    public bool IsRight
    {
        get
        {
            double[] sizes = { A, B, C };
            double maxSize = sizes.Max();
            double sum = sizes.Where(w => w != maxSize).Select(s => s * s).Sum();
            return Math.Abs((maxSize * maxSize - sum)) < 0.0001; //погрешность
        }
    }

    ///<summary>Is it possible triangle</summary>
    public bool IsPossible
    {
        get
        {
            double[] sizes = { A, B, C };
            double maxSize = sizes.Max();
            double sum = sizes.Where(w => w != maxSize).Sum();
            return maxSize < sum;
        }
    }

    ///<summary>Create triangle</summary>
    ///<param name="sideA">Side A</param>
    ///<param name="sideB">Side B</param>
    ///<param name="sideC">Side C</param>
    public Triangle(double sideA = 1, double sideB = 1, double sideC = 1)
    {
        if(sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new System.ArgumentException("Impossible values");
        
        A = sideA;
        B = sideB;
        C = sideC;
    }

    public override string ToString()
    {
        return string.Format($"Triangle [{A}-{B}-{C}]");
    }
}