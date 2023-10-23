using System.Text.RegularExpressions;
using Homework9.Homework9.Classes;

namespace Homework9.Homework9;

public static class Homework9_A
{
    public static void Execute()
    {
        // Use classes Shape, Circle, Square from your previous homework.
        // Use Linq and string functions to complete next tasks:
        
        // 1) Create list of Shape and fill it with 6 different shapes (Circle and Square).
        var list = new List<Shape>()
        {
            new Circle("Circle", 10.5),
            new Square("Square1", 154),
            new Circle("Circle2", 14.5),
            new Square("Square3", 178.4),
            new Circle("Circle8", 1425.1),
            new Square("Square9", 0)
        };

        // 2) Find and write into the file shapes with area from range [10,100]
        foreach (var item in list.Where(item => item.Area() >= 10 && item.Area()<=100))
            Console.WriteLine($"Item: {item.Name}, Area: {item.Area()}");

        // 3) Find and write into the file shapes which name contains letter 'a'    
        const string pathWrite = @"C:\Programming\SoftServe\Files\Homework9.txt";
        using (var writer = new StreamWriter(pathWrite))
        {
            var regex = new Regex("a+");
            foreach (var name in list.Select(shape => shape.Name).Where(name => regex.IsMatch(name)))
                writer.WriteLine(name);
        }

        // 4) Find and remove from the list all shapes with perimeter less then 5. Write resulted list into Console 
        list.RemoveAll(item => item.Perimeter() < 5);
        foreach (var item in list) 
            Console.WriteLine($"Item name: {item.Name}, Perimeter: {item.Perimeter()}");
    }
}