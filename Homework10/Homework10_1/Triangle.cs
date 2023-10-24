namespace Homework10.Homework10_1;

public class Triangle
{
    public Point[] Points { get; }
    private readonly double _ab, _ac, _bc;

    public Triangle()
    {
        Points = new[] { new Point(0,0), new Point(0,0), new Point(0,0)};
    }

    public Triangle(Point a, Point b, Point c)
    {
        Points = new[] { a, b, c };
        
        _ab = Points[0].Distance(Points[1]);
        _ac = Points[0].Distance(Points[2]);
        _bc = Points[1].Distance(Points[2]);
    }

    // Perimeter
    public double Perimeter() => _ab + _ac + _bc;

    // Area of triangle
    public double Square()
    {
        //  S = √p · (p — a)(p — b)(p — c)
        var p = Perimeter() / 2;
        return Math.Sqrt(p * (p - _ab) * (p - _ac) * (p - _bc));
    }
    
    // Output info
    public void Print() => Console.WriteLine($"Triangle: Perimeter: {Perimeter()}, Square: {Square()}");
}
