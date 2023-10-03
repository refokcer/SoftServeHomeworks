namespace Homework4;

public class Car
{
    // Task4 ( 1 task ) Создаем необходимые поля
    private string name;
    private string color;
    private decimal price;
    private const string CompanyName = "Any Company";

    // Task4 ( 3 task ) Создаем гетер сетер для цвета
    public string Color
    {
        get
        {
            return color;    // возвращаем значение свойства
        }
        set
        {
            color = value;   // устанавливаем новое значение свойства
        }
    }

    // Task4 ( 2 task ) дефолтный коструктор потому что дальше есть не дефолтный
    public Car()
    {
        name = "No name";
        color = "No color";
        price = 0;
    }

    // Конструктор по данным
    public Car(string name, string color, decimal price)
    {
        this.name = name;
        this.color = color;
        this.price = price;
    }

    // Task4 ( 4 task ) Ввод всех входных данных с клавиатры
    public static Car Input()
    {
        var name = MyUtilite.EnterValue<string>("Enter the name of the Car:");
        var color = MyUtilite.EnterValue<string>("Enter the color of the Car");
        var price = MyUtilite.EnterValue<decimal>("Enter the price of the Car:");

        return new Car(name, color, price);
    }
    
    // Task4 ( 5 task ) Выводим инфо про машину
    public void Print()
    {
        Console.WriteLine($"Name: {name}, Color: {color}, Price: {price}, Company: {CompanyName}");
    }
}