namespace Homework7.Task7;

public static class Task7_3
{
    public static void Execute()
    {
        try  
        {
            string[] txtFiles = Directory.GetFiles(@"E:\", "*.txt");
            
            foreach(string file in txtFiles) 
            {
                string text = File.ReadAllText(file);
                Console.WriteLine(text); 
            }
        }  
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}