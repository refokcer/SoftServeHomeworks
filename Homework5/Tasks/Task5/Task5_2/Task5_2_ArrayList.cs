using System.Collections;

namespace Homework5;

public static class Task5_2_ArrayList
{
    public static void Execute()
    {
        // Declare collection (ArrayList) myColl of 10 integers
        var myColl = new ArrayList(10);
        // myColl.AddRange(new []{10, 40, 78, -10, -10, -5, 10, -10, 64, -10});
        
        // Read from console
        Console.WriteLine("Enter 10 numbers:");
        for (var i = 0; i < 10; i++)
            myColl.Add(MyUtilite.EnterValue<int>($"Enter {i+1} number:"));

        // Output our collection:
        MyUtilite.Output(myColl, "\nCollection:");
        
        // Find and print all positions of element “-10” in this collection;
        var positions = FindPositionsOf(myColl, -10);
        MyUtilite.Output(positions, $"\nPositions of {-10} in myCall:");
        
        
        // Remove from collection elements, which are greater then 20.  Print new collection;
        myColl = RemoveFromArrayListGreaterThen(myColl, 20);
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
        MyUtilite.Output(myColl, "\nSorted ArrayList: ");
    }
    
    private static ArrayList FindPositionsOf(ArrayList arrayList, int number)
    {
        // Создаем новый ArrayList
        var newArrayList = new ArrayList();
        
        // Проходим и сравнивем, если подходит то записываем в новый массив
        for (var i = 0; i < arrayList.Count; i++)
        {
            if((int)arrayList[i]! == number) newArrayList.Add(i);
        }
        
        // Возвращаем новый ArrayList 
        // При таком подходе время составит O(n) но память займет O(2n) 
        // При видалені кожного окремо час був би O(k*n) 
        return newArrayList;
    }
    
    private static ArrayList RemoveFromArrayListGreaterThen(ArrayList arrayList, int number)
    {
        var newArrayList = new ArrayList();
    
        foreach (var item in arrayList)
        {
            if ((int)item! <= number) newArrayList.Add(item);
        }

        return newArrayList;
    }
}