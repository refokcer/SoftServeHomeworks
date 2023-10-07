namespace Homework5;

// Plane  (with fields: mark and highFly) , which implement interface IFlyable.
public class Plane : IFlyable
{
    // with fields: mark and highFly) 
    private string _mark;
    private int _highFly;

    // Constructor without parameters
    public Plane()
    {
        _mark = "No mark";
        _highFly = 2000;
    }
    
    // Constructor with parameters
    public Plane(string mark, int highFly)
    {
        _mark = mark;
        _highFly = highFly;
    }

    // Method from interface
    public void Fly() => Console.WriteLine("This plane is flying now!");
    
    // override ToString
    public override string ToString() => $"Info:\n Mark: {_mark}, Height of fly: {_highFly}";
}