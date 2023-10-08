using Homework5.Tasks.Homework5.Homework5_1;
using Homework5.Tasks.Homework5.Homework5_2;

namespace Homework5;

internal static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Task5_1");
        Task5_1.Execute();
        
        Console.WriteLine("Task5_2 with using list");
        Task5_2_List.Execute();
        
        Console.WriteLine("Task5_2 with using ArrayList");
        Task5_2_ArrayList.Execute();
        
        // Задача былв написана в комментариях к слайду
        Console.WriteLine("Task5_3");
        Task5_3.Execute();
        
        Console.WriteLine("Homework5_1:");
        Homework5_1.Execute();
        
        Console.WriteLine("Homework5_2:");
        Homework5_2.Execute();
    }
}