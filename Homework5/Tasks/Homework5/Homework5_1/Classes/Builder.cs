using Homework5.Tasks.Homework5.Homework5_1.Interfaces;

namespace Homework5.Tasks.Homework5.Homework5_1.Classes;

public class Builder : IDeveloper
{
    private string Tool { get; set; }

    // Constructors
    public Builder()
    {
        Tool = "No tool";
    }
    
    public Builder(string tool)
    {
        Tool = tool;
    }


    // Methods from interface
    public void Create() => Console.WriteLine("The Builder created something");

    public void Destroy() => Console.WriteLine("The builder destroying house");

    // Для удобного вывода
    public override string ToString() => $"The tool of this Builder is {Tool}";
}