namespace Homework4;

public class Car
{
    // Task4 ( 1 task ) Define class Car with fields name, color, price and const field CompanyName            
    private string name;
    private string color;
    private decimal price;
    private const string CompanyName = "Any Company";

    // Task4 ( 3 task ) Create a property to access the color field.
    public string Color
    {
        get => color; // возвращаем значение свойства
        set => color = value.ToLower(); // устанавливаем новое значение свойства
    }

    // Task4 ( 2 task ) Create two constructors - default and with parameters.
    public Car()
    {
        name = "No name";
        color = "No color";
        price = 0;
    }

    // Constructor with parameters.
    public Car(string name, string color, decimal price)
    {
        this.name = name;
        this.color = color.ToLower();
        this.price = price;
    }

    // Task4 ( 4 task ) Define methods: Input () - to enter data about cars from the console
    public static Car Input()
    {
        var name = MyUtilite.EnterValue<string>("Enter the name of the Car:");
        var color = MyUtilite.EnterValue<string>("Enter the color of the Car").ToLower();
        var price = MyUtilite.EnterValue<decimal>("Enter the price of the Car:");

        return new Car(name, color, price);
    }

    // Task4 ( task 6 ) ChangePrice (double x) - to change the price by x%
    public void ChangePrice(double x)
    {
        Console.WriteLine($"Last price: {price}");
        price -= price * (decimal)x / 100;
        Console.WriteLine($"New price: {price}\n");
    }

    // Task4 ( task 5 ) Print () - to output data about cars on the console
    public void Print()
    {
        Console.WriteLine($"Name: {name}, Color: {color}, Price: {price}, Company: {CompanyName}");
    }

    // Task4 ( task 10 ) Overload operator == for the class Car (cars - equal if the name and price are equal)
    public static bool operator == (Car first, Car second)
    {
        return first.name == second.name && first.price == second.price;
    }

    // Необходимо переопределять их в паре 
    public static bool operator !=(Car first, Car second)
    {
        return !(first == second);
    }


    // Task4 ( 11 task ) Override method ToString()  in the class Car, which returns a line with data about cars
    public override string ToString()
    {
        return "Info about car:\n" +
               $"Name: {name}, Color: {color}, Price: {price}, Company: {CompanyName}\n";
    }
}