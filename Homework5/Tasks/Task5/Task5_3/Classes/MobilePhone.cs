namespace Homework5;

public class MobilePhone : IPhone
{
    public string Name { get; set; }
    public int Price { get; set; }
    
    // Constructor
    public MobilePhone()
    {
        Name = "Noname";
        Price = 0;
    }

    // Constructor
    public MobilePhone(string name, int price)
    {
        Name = name;
        Price = price;
    }

    // Method from interface
    public void Info() => Console.WriteLine("This is mobile phone");
    
    // Для удобного вывода информации
    public override string ToString() => $"Name: {Name}, Price: {Price}\n";
}