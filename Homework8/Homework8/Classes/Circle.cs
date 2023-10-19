namespace Homework8.Homework8.Classes;

public class Circle : Shape
{
    private double _radius;

    public Circle(string name, double radius) : base(name)
    {
        _radius = radius;
    }

    public override double Area() => _radius * _radius * Math.PI;

    public override double Perimeter() => 2 * Math.PI * _radius;
}