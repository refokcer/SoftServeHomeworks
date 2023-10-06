namespace Homework5;

public class Bird : IFlyable
{
    // 
    private string _name;
    private bool _canFly;

    // Method from interface
    public void Fly() => Console.WriteLine("This bird is flying now!");
    }