namespace Homework5;

public interface IPhone : IComparable<IPhone>
{
    // Поля для создания метода CompareTo
    public string Name
    {
        get => Name;
        set => Name = value;
    }

    public int Price
    {
        get => Price;
        set => Price = value;
    }
    
    // Output info
    public void Info() => Console.WriteLine("This is phone");
    
    // For compare ( sort )
    int IComparable<IPhone>.CompareTo(IPhone? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        if (Price.CompareTo(other.Price) != 0) return Price.CompareTo(other.Price);
        return string.Compare(Name, other.Name, StringComparison.Ordinal);
    }
}