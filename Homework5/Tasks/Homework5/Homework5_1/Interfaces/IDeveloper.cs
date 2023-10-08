namespace Homework5.Tasks.Homework5.Homework5_1.Interfaces;

public interface IDeveloper : IComparable<IDeveloper>
{
    public string Tool
    {
        get => Tool;
        set => Tool = value;
    }

    // Methods
    public void Create();
    public void Destroy();
    
    // Сравниваем интерфейсы по предмету
    int IComparable<IDeveloper>.CompareTo(IDeveloper? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        return string.Compare(Tool, other.Tool, StringComparison.Ordinal);
    }
}