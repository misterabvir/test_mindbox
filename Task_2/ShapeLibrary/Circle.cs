namespace ShapeLibrary;

///<summary>Class of circles</summary>
public class Circle : ShapeBase
{
     ///<summary>What is this?</summary>
    public override ShapeKind ShapeIs()
    {
        return ShapeKind.circle;
    }
    private double _radius;   
    ///<summary>Radius</summary>
    public double Radius
    {
        get { return _radius; }
        set
        {
             if (value <= 0)
                throw new System.Exception($"Class Circle. Impossible value \'{nameof(Radius)}\'.");
            _radius = value;
        }
    }
    ///<summary>Diameter of circle</summary>
    public double Diameter => 2 * Radius;

    ///<summary>Circle length</summary>
    public double CircleLength => 2 * Math.PI * Radius;
    
    ///<summary>Square of circle</summary>
    public override double Square() => Math.PI * Radius * Radius;

    ///<summary>Create circle</summary>
    public Circle(double radius = 1.0D)
    {      
        Radius = radius;
    }
}