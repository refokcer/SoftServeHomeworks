using Homework5.Tasks.Homework5.Homework5_1.Classes;
using Homework5.Tasks.Homework5.Homework5_1.Interfaces;

namespace Homework5.Tasks.Homework5.Homework5_1;

public static class Homework5_1
{
    public static void Execute()
    {
        // Create list of IDeveloper objects
        var listOfDevelopers = new List<IDeveloper>()
        {
            new Builder(),
            new Programmer(),
            new Programmer("1", "JS"),
            new Programmer("2", "JS"),
            new Programmer("3", "C#"),
            new Builder("1"),
            new Builder("2"),
        };

        // Call Create() and Destroy() methods for all of it
        for (var i = 0; i < listOfDevelopers.Count; i++)
        {
            Console.WriteLine($"Create and Destroy of {i+1} developer");
            
            listOfDevelopers[i].Create();
            listOfDevelopers[i].Destroy();
            
            Console.WriteLine();
        }

        // Sorting this list
        listOfDevelopers.Sort();
        
        // Output list
        MyUtilite.Output(listOfDevelopers);
    }
}