namespace Homework5;

public class Plane : IFlyable
{
    private string _mark;
    private bool _highFly;
        
    public void Fly() => Console.WriteLine("This plane is flying now!");
}