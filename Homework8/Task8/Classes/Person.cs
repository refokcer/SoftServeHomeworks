namespace Homework8.Task8.Classes;

using System;

public abstract class Person : IComparable
{
    private string _name;

    protected Person(string name, string surname)
    {
        _name = name;
        Surname = surname;
    }

    public virtual string Name => _name;
    protected string Surname { get; }

    public virtual void Print()
    {
        Console.WriteLine("This is person: {0} {1}", this._name, this.Surname);
    }
    public abstract void Output();
    
    public virtual int CompareTo(object? obj1)
    {
        if (obj1 is not Person p1)
            throw new ArgumentException("Object is not a Person");
        
        return string.Compare(Name.ToLower(), p1.Name.ToLower(), StringComparison.Ordinal);
    }
}
