namespace Homework5.Tasks.Homework5.Homework5_1.Interfaces;

public interface IDeveloper
{
    private string Tool
    {
        get => Tool;
        set => Tool = value;
    }

    // Methods
    public void Create();
    public void Destroy();
}