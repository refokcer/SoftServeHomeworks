namespace Homework4;

internal static class Program
{
    public static void Main(string[] args)
    {
        // Task4 ( task 7 ) Enter data about 3 cars.
        var cars = new Car[3];

        cars[0] = new Car();
        cars[1] = new Car("Second Car", "white", 100);
        cars[2] = Car.Input();
        
        // Task4 ( task 8 ) Decrease car price by 10%, display info about the car on the console
        var i = 1;
        foreach (var car in cars)
        {
            Console.WriteLine($"\nInfo about {i++} Car:");
            car.ChangePrice(10);
            Console.WriteLine(car);
        }

        // Task4 ( task 9 ) Enter a new color and “repaint” the car from the color white in the defined color
        var newColor = MyUtilite.EnterValue<string>("Enter the color in which to repaint the white cars:");
        var check = true;
        
        Console.WriteLine("Cars that have been repainted: ");
        foreach (var car in cars)
        {
            if (car.Color != "white") continue;
            
            car.Color = newColor;
            check = false;

            Console.WriteLine(car);
        }
        
        if(check) Console.WriteLine("There were no white cars");
    }
}