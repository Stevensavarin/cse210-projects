public class Circle : Shape
{
    private double _raidus;

    public Circle(string color, double radius) : base (color)
    {
        _raidus = radius;
    }

    public override double GetArea()
    {
        return _raidus * _raidus * Math.PI;
    }
}