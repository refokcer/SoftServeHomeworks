namespace Homework5.Tasks.Homework5.Homework5_2;

public static class Homework5_2
{
    public static void Execute()
    {
        // declare Dictionary<uint,string>. 
        var dict = new Dictionary<uint, string>();
        uint id;
        string? name;
        
        // Add to Dictionary  from Console 7 pairs (ID, Name) of some persons.
        Console.WriteLine("Input 7 pairs of ( ID<int>, Name<string> )");
        for (var i = 0; i < 7; i++)
        {
            // Enter from console pair of <ID, name> and check ID if it is not correct
            id = MyUtilite.EnterValue<uint>($"Enter {i + 1} ID ( >=0 ) witch didn't exist:", check => !dict.ContainsKey(check), 
                "This ID was already existed! Enter another ID.");
            name = MyUtilite.EnterValue<string>($"Enter {i + 1} name:");

            // Add new pair to dictionary
            if (!dict.TryAdd(id, name)) Console.WriteLine("Person with this ID already existed!");
        }
        
        // Output dictionary
        MyUtilite.Output(dict);
        
        // Ask user to enter ID, then find and write corresponding Name from your Dictionary. 
        id = MyUtilite.EnterValue<uint>("Enter ID for find corresponding name");
        dict.TryGetValue(id, out name);
        Console.WriteLine(name != null ? $"Name of {id} is {name}." : "We haven't person with this ID!");
    }
}