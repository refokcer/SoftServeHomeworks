using Homework8.Homework8.Classes;

namespace Homework8.Homework8;

public static class Homework8
{
    public static void Execute()
    {
        // a) In Main() create list of Shape, then ask user to enter data of 10 different shapes. 
        var list = new List<Shape>()
        {
            new Circle("Circle", 10.5),
            new Square("Square1", 154),
            new Circle("Circle2", 14.5),
            new Square("Square3", 178.4),
            new Circle("Circle4", 105),
            new Square("Square5", 14.45),
            new Circle("Circle6", 0.5),
            new Square("Square7", 1544),
            new Circle("Circle8", 1425.1),
            new Square("Square9", 0)
        };

        // Find shape with the largest perimeter and print its name. 
        var mx = 0.0;
        var name = "";
        
        //  Write name, area and perimeter of all shapes.
        foreach (var item in list)
        {
            Console.WriteLine($"Name: {item.Name}, Area: {item.Area()}, Perimeter: {item.Perimeter()}");
            if (item.Perimeter() > mx) name = item.Name;
        }
        
        Console.WriteLine($"The largest perimeter have shape with name: {name}");
        
        // Sort shapes by area and print obtained list (Remember about IComparable)
        list.Sort();

        foreach (var shape in list)
        {
            Console.WriteLine($"Name: {shape.Name}: Area: {shape.Area()}");
        }
    }
}