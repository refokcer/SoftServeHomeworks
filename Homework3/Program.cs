namespace Homework3;

internal static class Program
{
    public static void Main(string[] args)
    {
        // После кажного задания программа ожидает нажатия клавиши для перехода на следующие задание
        Console.WriteLine("After each task, the program waits for a key press to move to the next task");

        Console.WriteLine("\nTasks from 'Task3':");
        
        Tasks.Task1();
        Tasks.Task2();
        Tasks.Task3();
        Tasks.Task4();
        Tasks.Task5();
        Tasks.Task6();
        Tasks.Task7(); 
        
        Console.WriteLine("\nTasks from 'Homework':");
        
        Homework.Task1();
        Homework.Task2();
        Homework.Task3();
    }
}