namespace Homework5;

public interface IFlyable
{
    public void Fly();

    public void Info() => Console.WriteLine("This object can fly");
}