using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Homework9.Homework9;

public static class Homework9_B
{
    public static void Execute()
    {
        // Prepare txt file with a lot of text inside (for example take you .cs file from previos homework)
        const string pathRead = @"C:\Programming\SoftServe\Files\Homework9_B.txt";
        
        // Read all lines of text from file into array of strings.
        //     Each array item contains one line from file.
        var list = new List<string>();
        using (var reader = new StreamReader(pathRead))
        {
            while (reader.ReadLine() is { } line)
                list.Add(line);
        }

        //     Complete next tasks:
        // 1) Count and write the number of symbols in every line.
        foreach (var item in list)
            Console.WriteLine(item.Length);

        // 2) Find the longest and the shortest line. 
        Console.WriteLine($"The largest strings consist {list.Max(item => item.Length)} leters;");
        Console.WriteLine("Largest string(s):");
        foreach (var item in list.Where(item => item.Length == list.Max(str => str.Length)))
            Console.WriteLine(item);
        
        Console.WriteLine();

        Console.WriteLine($"The smallest string consist {list.Where(item => item.Length > 0).Min(item => item.Length)} leters;");
        Console.WriteLine("Smallest string(s):");
        foreach (var item in list.Where(item => item.Length == list.Where(str => str.Length > 0).Min(str => str.Length)))
            Console.WriteLine(item);
        
        // 3) Find and write only lines, which consist of word "var"
        Console.WriteLine("Line which consist(s) 'var' :");
        var regex = new Regex("var+");
        foreach (var srt in list.Where(str => regex.IsMatch(str))) Console.WriteLine(srt);
    }
}