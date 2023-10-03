namespace Homework2;

internal static class Program
{
    public static void Main(string[] args)
    {
        // После кажного задания программа ожидает нажатия клавиши для перехода на следующие задание
        Console.WriteLine("After each task, the program waits for a key press to move to the next task");
        
        Console.WriteLine("\nTasks from 'Task2':");
        
        Tasks.Task1();
        Tasks.Task2();
        Tasks.Task3();
        Tasks.Task4();
        Tasks.Task5();

        Console.WriteLine("\nTasks from 'Homework':");
        
        Homework.Task1();
        Homework.Task2();
        Homework.Task3();
        Homework.Task4();

        Console.WriteLine("\nTasks from 'Additional tasks'");
        
        AdditionalTasks.Task1();
        AdditionalTasks.Task2();

    }
}