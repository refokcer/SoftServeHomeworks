namespace Homework8.Task8.Classes;

using System;

public class Staff : Person, IComparable<Staff>
{
    protected internal Staff(string name, string surname, int salary) : base(name, surname)
    {
        Salary = salary;
    }

    protected int Salary { get; }

    public override string Name => base.Name; 
   
    public override void Print()
    {
        Console.WriteLine("Person {0} {1} has salary: {2}", Name, Surname, Salary);
    }

    public override void Output()
    {
        Console.WriteLine("abstract This is person: {0} {1}", Name, Surname);
    }


    public int CompareTo(Staff? p)
    {
        Staff? d = p as Developer;
        Staff? t = p as Teacher;
        if (d != null)
            return Salary.CompareTo(d.Salary);
        if (t != null)
            return Salary.CompareTo(t.Salary);
        
        throw new Exception("Unable to compare two objects");
    }

}
