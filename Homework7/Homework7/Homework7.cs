namespace Homework7.Homework7;

public static class Homework7
{
    public static void Execute()
    {
        // Dictionary for phonebook and ways to read and save files
        var phoneBook = new Dictionary<string, string>();
        
        const string pathRead = @"C:\Programming\SoftServe\Files\phones.txt";
        const string pathWrite = @"C:\Programming\SoftServe\Files\onlyPhones.txt";

        // Homework7_1
        ReadFromWriteToOnlyPhones(ref phoneBook, pathRead, pathWrite);
        
        // Homework7_2
        FindPhoneByName(phoneBook);
        
        // Homework7_3
        CorrectAllNumbersIn(ref phoneBook);
    }

    private static void CorrectAllNumbersIn(ref Dictionary<string, string> phoneBook)
    {
        // Path to save the file
        const string pathWrite = @"C:\Programming\SoftServe\Files\New.txt";

        //Phone number update list
        //Since the phone number is a key it cannot be changed. Therefore,
        //  we delete the pair and write a new one with a new key. 
        //In the process of phoneBook enumeration it is impossible to change its size,
        //  so we write it separately in the list to change it in a separate enumeration.
        var toUpdate = new List<KeyValuePair<string, string>>();
        
        // Go through the phoneBook and write down which keys need to be changed.
        // Also write the changed phone numbers to a new file 
        using (var writer = new StreamWriter(pathWrite))
        {
            foreach (var (key, value) in phoneBook)
            {
                if (key.StartsWith("+38")) continue;

                var newKey = "+38" + key;
                
                toUpdate.Add(new KeyValuePair<string, string>(key, value));

                Console.WriteLine($"Number: {key} was reformat into {newKey}");
                writer.WriteLine($"{newKey} - {value}");
            }
        }
        
        // Changing the keys in the phoneBook
        foreach (var (key, value) in toUpdate)
        {
            phoneBook.Remove(key);
            phoneBook.TryAdd("+38" + key, value);
        }
    }

    private static void ReadFromWriteToOnlyPhones(ref Dictionary<string, string> phoneBook, in string pathRead, in string pathWrite)
    {
        // Reading from the file
        using (var sr = new StreamReader(pathRead))
        {
            // Line by line
            string? line;
            while ((line = sr.ReadLine()) != null)
            {
                var parts = line.Split('-');
                
                // Fill in the phoneBook
                if (!phoneBook.TryAdd(parts[0].Trim(' '), parts[1].Trim(' ')))
                    Console.WriteLine($"Phone number of {parts[1].Trim()} already exists!");
            }
        }

        // Write only phone numbers to the file 
        using (var writer = new StreamWriter(pathWrite))
        {
            foreach (var key in phoneBook.Keys)
            {
                writer.WriteLine(key);
            }
        }
    }

    private static void FindPhoneByName(in Dictionary<string, string> phoneBook)
    {
        var name = MyUtilite.EnterValue<string>("Enter the name of person to search");

        // Check if the name is in the phoneBook
        if (!phoneBook.ContainsValue(name))
            Console.WriteLine("This phoneBook have not this person");
        else
        {
            // In case there's more than one person with that name
            var list = (from pair in phoneBook where pair.Value == name select pair.Key).ToList();

            // The name is one
            if (list.Count == 1) Console.WriteLine($"Phone number of {name} is {list[0]}");
            else
            {
                // There's not a lot of names
                Console.WriteLine("Here is some people with this name. Here is all numbers:");

                foreach (var item in list)
                    Console.WriteLine(item);
            }
        }
    }
}   