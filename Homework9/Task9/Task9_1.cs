namespace Homework9.Task9;

public static class Task9_1
{
    public static void Execute()
    {
        // Create a collection(array) of 10 integers numbers
        var list = new List<int>(10)
        {
            1, 2, 3, -5, -10, 50, 170, -154, 0, 78            
        };
        
        // Get and display only negative numbers on the console
        MyUtilite.Output(list.Where(item => item < 0));
        
        // Get and display only positive numbers on the console
        MyUtilite.Output(list.Where(item => item >= 0));
        
        // Find the sum of all elements of the array.
        var sum = list.Sum();
        Console.WriteLine($"Sum of Array: {sum}");
        
        // Get the largest and smallest elements from the array. 
        Console.WriteLine($"Max number: {list.Max()}, Min number: {list.Min()}");
        
        // Get the first largest element in array that is smaller than the Average of elements in array
        var avr = list.Average();

        Console.WriteLine("Largest number in array, that smaller than avr of array: " +
                          $"{list.Where(item => item < avr).Max()}");

        // Sort the array using OrderBy
        var sortedList = list.OrderBy(item => item);
        MyUtilite.Output(sortedList);
    }
}