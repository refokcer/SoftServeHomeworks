namespace Homework7.Task7;

public static class Task7_3
{
    public static void Execute()
    {
        try  
        {
            // Files from disc E
            string[] txtFiles = Directory.GetFiles(@"E:\", "*.txt");
            
            // Read files and output all text from them
            foreach(string file in txtFiles) 
            {
                string text = File.ReadAllText(file);
                Console.WriteLine(text); 
            }
        }  
        catch (Exception ex)
        {
            // Catch exception
            Console.WriteLine(ex.Message);
        }
    }
}