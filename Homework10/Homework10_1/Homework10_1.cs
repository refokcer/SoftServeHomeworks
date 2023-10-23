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
            new Triangle(a, b ,c),
            new Triangle(a, d ,c),
            new Triangle(d, e ,b)
        };

        foreach (var item in list)
            item.Print();
        
        // Print the triangle with vertex which is the closest to origin (0,0)
        // var dist = list[0].Points[0].Distance(new Point(0, 0));
        // var ans = 0;
        //
        // for (var i = 0; i < 3; i++)
        // {
        //     var dist1 = list[0].Points[0].Distance(new Point(0, 0));
        // }
        
    }
}