using System.Collections;

namespace Homework5;

public static class Task5_2_List
{
    public static void Execute()
    {
        // Declare collection (List) myColl of 10 integers
        var myColl = new List<int>(10);
        // myColl.AddRange(new []{10, 40, 78, -10, -10, -5, 10, -10, 64, -10});

        // Read from console
        Console.WriteLine("Enter 10 numbers:");
        for (var i = 0; i < 10; i++)
            myColl.Add(MyUtilite.EnterValue<int>($"Enter {i + 1} number:"));

        // Output our collection:
        MyUtilite.Output(myColl, "\nCollection:");

        // Find and print all positions of element “-10” in this collection;
        var positions = FindPositionsOf(myColl, -10);
        MyUtilite.Output(positions, $"\nPositions of {-10} in myCall:");


        // Remove from collection elements, which are greater then 20.  Print new collection;
        myColl.RemoveAll(check => check > 20);
        MyUtilite.Output(myColl, "\nmyCall without numbers > 20 :");


        // Insert elements 1,-3,-4 in positions 2, 8, 5. Print new collection;
        if (myColl.Count >= 2) myColl.Insert(2, 1);
        else Console.WriteLine("We can't insert in 2 position");

        if (myColl.Count >= 8) myColl.Insert(8, -3);
        else Console.WriteLine("We can't insert in 8 position");

        if (myColl.Count >= 5) myColl.Insert(5, -4);
        else Console.WriteLine("We can't insert in 5 position");

        MyUtilite.Output(myColl, "\nCollection after inserts");


        // Sort and print collection
        myColl.Sort();
        MyUtilite.Output(myColl, "\nSorted list: ");
    }

    private static List<int> FindPositionsOf(List<int> list, int number)
    {
        var newList = new List<int>();
        for (var i = 0; i < list.Count; i++)
        {
            if (list[i] == number) newList.Add(i);
        }

        return newList;
    }
}