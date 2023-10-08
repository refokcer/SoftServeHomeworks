using Homework5.Tasks.Homework5.Homework5_1.Interfaces;

namespace Homework5.Tasks.Homework5.Homework5_1.Classes;

public class Programmer : IDeveloper
{
    public string Tool { get; set; }
    private string Language { get; set; }
    
    // Constructors
    public Programmer()
    {
        Tool = "No tool";
        Language = "No language";
    }
    
    public Programmer(string tool, string language)
    {
        Tool = tool;
        Language = language;
    }

    // Methods from interface
    public void Create() => Console.WriteLine("The programmer created something");

    public void Destroy() => Console.WriteLine("The programmer destroying Data Base");
    
    // Для удобного вывода
    public override string ToString() => $"The tool of this Programmer is {Tool} and language is {Language}\n";
}