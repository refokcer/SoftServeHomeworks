namespace Homework4;

internal static class Program
{
    public static void Main(string[] args)
    {
        Task4();
        Homework();
    }

    private static void Task4(){
        // Task4 ( task 7 ) Enter data about 3 cars.
        var cars = new Car[3];

        cars[0] = new Car();
        cars[1] = new Car("Second Car", "white", 100);
        cars[2] = Car.Input();
        
        // Task4 ( task 8 ) Decrease car price by 10%, display info about the car on the console
        var i = 1;
        foreach (var car in cars)
        {
            Console.WriteLine($"\nInfo about {i++} Car:");
            car.ChangePrice(10);
            Console.WriteLine(car);
        }

        // Task4 ( task 9 ) Enter a new color and “repaint” the car from the color white in the defined color
        var newColor = MyUtilite.EnterValue<string>("Enter the color in which to repaint the white cars:");
        var check = true;
        
        Console.WriteLine("Cars that have been repainted: ");
        foreach (var car in cars)
        {
            if (car.Color != "white") continue;
            
            car.Color = newColor;
            check = false;

            Console.WriteLine(car);
        }
        
        if(check) Console.WriteLine("There were no white cars");
    }

    private static void Homework()
    {
        // Homework 4 ( task 1 ) In the method Main() create 6 objects of Person type and enter information about them.
        var persons = new Person[6];
        
        persons[0] = new Person();
        persons[1] = new Person("Kyril", new DateTime(2018, 4, 5));
        
        Console.WriteLine("Info about 1 and 2 Person already exist");
        for (var i = 2; i < 6; i++)
        {
            Console.WriteLine($"Enter info about {i+1} Person:");
            persons[i] = Person.Input();
        }

        // Homework 4 ( task 2 ) Then calculate and output on the console name and Age of each person; 
        foreach (var person in persons)
        {
            Console.WriteLine(person.Name);
            person.Age(true);
        }
        
        // Homework 4 ( task 3 ) Change the name of persons, which Age is less then 16, to "Very Young".
        foreach (var person in persons)
        {
            if (person.Age() < 16)
                person.ChangeName("Very Young");
        }
        
        // Homework 4 ( task 4 ) Output information about all persons on the console.
        for(var i = 0; i < 6; i++)
        {
            Console.WriteLine($"Info about {i+1} person:");
            persons[i].Output();
        }

        // Homework 4 ( task 5 ) Find and output information about Persons with the same names (use ==).
        for (var i = 0; i < 5; i++)
        {
            for (var j = i+1; j < 6; j++)
            {
                if (persons[i] == persons[j])
                {
                    Console.WriteLine("Two people matched\n" +
                                      $"First:\n{persons[i]}\n" +
                                      $"Second:\n{persons[j]}\n");
                }
            }
        }
    }
}