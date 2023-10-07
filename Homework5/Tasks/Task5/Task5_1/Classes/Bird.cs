namespace Homework5;


// Bird (with fields: name and canFly) which implement interface IFlyable.  
public class Bird : IFlyable
{
    // with fields: name and canFly
    private string _name;
    private bool _canFly;
    
    // Constructor without parameters
    public Bird()
    {
        _name = "No name";
        _canFly = false;
    }
    
    // Constructor with parameters
    public Bird(string name, bool canFly)
    {
        _name = name;
        _canFly = canFly;
    }
    
    // Method from interface
    public void Fly() => Console.WriteLine(_canFly ? "This bird is flying now!" : "This bird can't fly");
    
    // override ToString
    public override string ToString() => $"Info:\n Name: {_name}, Can fly: {(_canFly ? "Can" : "Can't")}";
}