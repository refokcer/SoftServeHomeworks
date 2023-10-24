namespace Homework10.Homework10_1;

public static class Homework10_1
{
    public static void Execute()
    {
        var a = new Point(10, 15);
        var b = new Point(-5, 45);
        var c = new Point(0, 5);
        var d = new Point(4, 24);
        var e = new Point(5, -10);

        // create list of 3 triangles and write into console the information about these shapes.
        var list = new List<Triangle>()
        {
            new Triangle(a, b ,e),
            new Triangle(a, d ,c),
            new Triangle(d, e ,b)
        };

        foreach (var item in list)
            item.Print();
        
        // Print the triangle with vertex which is the closest to origin (0,0)
        var minDist = list[0].Points[0].Distance(new Point(0, 0));
        var ans = 0;
        
        for (var i = 0; i < 3; i++)
        {
            var points = list[i].Points;
            foreach (var item in points)
            {
                var newDist = item.Distance(new Point(0, 0));
                if (!(newDist < minDist)) continue;
                minDist = newDist;
                ans = i;
            }
        }
        
        Console.WriteLine($"The {ans+1} triangle has the closest point to (0, 0) with distance {minDist}");
        
    }
}