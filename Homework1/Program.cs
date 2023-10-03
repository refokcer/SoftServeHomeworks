namespace Homework1;

internal static class Program
{
    public static void Main(string[] args)
    {
        // Я бы отдельно хотя бы по функциям рассписал, но в ззадании писать в Main
        
        
        // ************************ First task *******************************
        Console.WriteLine("\nFirst task:");
        
        // Enter side of a square
        Console.WriteLine("Enter side of the square:");
        int a = Convert.ToInt32(Console.ReadLine());
        
        // Calculate area and perimeter of the square
        int areaOfSquare      = a * a;
        int perimeterOfSquare = 4 * a;
        
        // Output area and perimeter of the square
        Console.WriteLine($"Area of the square: {areaOfSquare}");
        Console.WriteLine($"Perimeter of the square: {perimeterOfSquare}");
        
        
        
        // ************************ Second task *******************************
        Console.WriteLine("\nSecond task:");
        
        // Define name and age
        string? name;
        int age;
        
        // First question
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        
        // Second question
        Console.WriteLine($"How old are you, {name}?");
        age = Convert.ToInt32(Console.ReadLine());
        
        // Output full info about person
        Console.WriteLine($"Name: {name}, Age: {age}");
        
        
        
        // ************************ Third task *******************************
        Console.WriteLine("\nThird task:");

        // Enter radius of circle
        Console.WriteLine("Enter radius of circle:");
        double r = Convert.ToDouble(Console.ReadLine());
        
        // Define length, area, volume and calculate them
        double length = 2 * Math.PI * r;
        double area   = Math.PI * r * r;
        double volume = (4.0 / 3.0) * Math.PI * r * r * r;
        
        // Output all info
        Console.WriteLine($"Length: {Math.Round(length, 5)}\n" +
                          $"Area  : {Math.Round(area  , 5)}\n" +
                          $"volume: {Math.Round(volume, 5)}\n");
    }
}