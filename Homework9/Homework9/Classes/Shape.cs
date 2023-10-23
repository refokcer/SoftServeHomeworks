namespace Homework9.Homework9.Classes;

public abstract class Shape : IComparable
{
    private string _name;

    public virtual string Name => _name;

    protected Shape(string name)
    {
        _name = name;
    }
    
    public abstract double Area();
    
    public abstract double Perimeter();
    
    public virtual int CompareTo(object? obj1)
    {
        if (obj1 is not Shape p1)
            throw new ArgumentException("Object is not a Person");

        return Area().CompareTo(p1.Area());
    }
}