namespace Homework8.Task8.Classes;

internal class Developer : Staff
{
    private string _language;

    public Developer(string name, string surname, string language, int salary) : base(name, surname, salary)
    {
        _language = language;
    }

    public override void Print()
    {
        //base.Print();
        Console.WriteLine("Developer {0} {1} knows {2} and have salary:{3}", Name, Surname, _language, Salary);
    }
}

