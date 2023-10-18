using System.Net;
using System.Text;

namespace Homework7.Task7;

public static class Task7_1
{
    public static void Execute()
    {
        // Read and write file path
        const string pathRead = @"C:\Programming\SoftServe\Files\file.txt";
        const string pathWrite = @"C:\Programming\SoftServe\Files\res.txt";
        
        // Reading and writing from file to file
        ReadFromWriteTo(pathRead, pathWrite);
    }

    private static void ReadFromWriteTo(in string pathRead, in string pathWrite)
    {
        // Variable for line-by-line reading from file
        var text = new StringBuilder();
        
        try 
        {
            // Read the file line by line
            using (var sr = new StreamReader(pathRead))
            {
                while(sr.ReadLine() is { } line)
                    text.Append(line + '\n');
            }
            
            // Write everything to the right file
            File.WriteAllTextAsync(pathWrite, text.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}