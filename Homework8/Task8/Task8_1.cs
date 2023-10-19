using Homework7;
using Homework8.Task8.Classes;

namespace Homework8.Task8;

public static class Task8_1
{
    public static void Execute()
    {
        // 3. In Main, specify a list of Person type and add objects of each type to it.
        var people = new List<Person>
        {
            new Staff("Artem", "Karandashov", 8000),
            new Teacher("Polina", "Siotka", "Programming", 10000),
            new Developer("Anton", "Petrenko", "Java", 20000),
            new Developer("Kolya", "Nikitenko", "C#", 25000),
            new Teacher("Vasyl", "Vasylenko", ".NET", 15000)
        };
        
        // Call for each item in the list method Print ().
        foreach (var p in people)
            p.Print();

        Console.WriteLine();
        var personName = MyUtilite.EnterValue<string>("Enter the name of person");
        var t = false;
        
        foreach (var p in people.Where(p => personName == p.Name))
        {
            p.Print(); t = true;
        }
        
        
        if (!t) Console.WriteLine("There is no this person");
        
        
        people.Sort();
        const string path = @"C:\Programming\SoftServe\Files\Sorted_names.txt";
        
        using (var sw = new StreamWriter(path, false))
        {
            sw.WriteLine("Sorted names!");
            foreach (var person in people)
                sw.WriteLine(person.Name);
        }
        Console.WriteLine();
        
        var employees = new List<Staff>();
        
        foreach (var person in people)
        {
            var staff = (Staff)person;
            
            if (staff.GetType() == typeof(Developer) || staff.GetType() == typeof(Teacher))
                employees.Add(staff);
        }
        
        foreach (var staff in employees)
        {
            staff.Print();
        }
        
        employees.Sort();
        Console.WriteLine("\t\t*****************\t\tAfter sorting employees by salary\n");
        foreach (var staff in employees)
        {
            staff.Print();
        }
    }
}