namespace Homework5;

public class RadioPhone : IPhone
{
    public string Name { get; set; }
    public bool IsAutoresponder { get; set; }
    public int Price { get; set; }
    
    // Constructor
    public RadioPhone()
    {
        Name = "Noname";
        IsAutoresponder = false;
        Price = 0;
    }

    // Constructor
    public RadioPhone(string name,bool isAutoresponder, int price)
    {
        Name = name;
        IsAutoresponder = isAutoresponder;
        Price = price;
    }

    // Method from interface
    public void Info() => Console.WriteLine("This is radio phone");

    // Для удобного вывода информации
    public override string ToString() => $"Name: {Name}, Price: {Price}\n";
}