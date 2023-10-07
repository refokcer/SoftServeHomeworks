namespace Homework5;

public static class Task5_1
{
    public static void Execute()
    {
        // Task 5.3 Create List of IFlyable objects.
        var listOfFlyable = new List<IFlyable> { new Bird(), new Plane() };

        // Task 5.3 Add some Birds and Planes to it. 
        listOfFlyable.Add(new Bird("My bird", true));
        listOfFlyable.Add(new Plane("My plane", 5000));

        // Task 5.3 Call Fly() method for every item from the list of it. 
        foreach (var item in listOfFlyable)
            item.Fly();
    }
}