namespace Homework8.Task8.Classes;

using System;

internal class Teacher : Staff
{
    private string _subject;

    public Teacher(string name, string surname, string subject, int salary) : base(name, surname, salary)
    {
        _subject = subject;
    }
    public override void Print()
    {
        Console.WriteLine("Teacher {0} {1} is a teaches {2} with salary:{3}", Name, Surname, _subject, Salary);
    }
}
