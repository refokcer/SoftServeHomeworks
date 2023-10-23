namespace Homework9.Homework9.Classes;

public class Square : Shape
{
    private double _side;

    public Square(string name, double side) : base(name)
    {
        _side = side;
    }

    public override double Area() => _side * _side;

    public override double Perimeter() => _side * 4.0;
}