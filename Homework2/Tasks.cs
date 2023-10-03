namespace Homework2;

public static class Tasks
{
    public static void Task1()
    {
        Console.WriteLine("\nFirst task:");
        
        // Вводим два числа
        var num1 = MyUtilite.EnterValue<int>("Enter first number: ");
        var num2 = MyUtilite.EnterValue<int>("Enter second number: ");

        // Проверям в дату в порялк у день месяц ( при вводе )
        if (MyUtilite.IsDate(num1, num2))
        {
            if (num2 == 2 && num1 == 29) Console.WriteLine($"Possible date: Day:{num1};Month:{num2};Year:High Year");
            else Console.WriteLine($"Possible date: Day:{num1};Month:{num2};Year:Any year");
        }
        
        // В порядке месяц день ( при вводе )
        if(MyUtilite.IsDate(num2, num1))
        {
            if(num1 == 2 && num2 == 29) Console.WriteLine($"Possible date: Day:{num2};Month:{num1};Year:High year");
            else Console.WriteLine($"Possible date: Day:{num2};Month:{num1};Year:Any year");
        }
        
        // В случае если два числа вообще не могут быть датой
        if(MyUtilite.IsDate(num2, num1) == false && MyUtilite.IsDate(num1, num2) == false)
        {
            Console.WriteLine("Those two numbers can't be the date");
        }
        
        Console.ReadKey();
    }
    
    public static void Task2()
    {
        Console.WriteLine("\nSecond task:");
        
        // Вводим число ( дробная часть обязательно через запятую ! )
        var num = MyUtilite.EnterValue<double>("Enter number: ");

        // Считаем и выводим ответ
        Console.WriteLine(Math.Abs((int)(num * 10) % 10 + (int)(num * 100) % 10));
        
        Console.ReadKey();
    }

    public static void Task3()
    {
        Console.WriteLine("\nThird task:");
        
        // Вводим количество часов
        var hours = MyUtilite.EnterValue<int>("Enter what hour is now");

        // Проверяем какая это часть дня
        switch (hours)
        {
            case >= 5 and <= 11:
                Console.WriteLine("Good morning!");
                break;
            case >= 12 and <= 14:
                Console.WriteLine("Good afternoon!");
                break;
            case >= 15 and <= 23:
                Console.WriteLine("Good evening!");
                break;
            case >= 0 and 24:
                Console.WriteLine("Good night!");
                break;
            default:
                Console.WriteLine("This number cannot be the number of hours in a day");
                break;
        }
        
        Console.ReadKey();
    }
    
    public static void Task4()
    {
        Console.WriteLine("\nFourth task:");
        
        // Создаем переменную
        var test1Status = TestCaseStatus.Pass;
        
        // Выводим ответ
        Console.WriteLine(test1Status);
        
        Console.ReadKey();
    }

    enum TestCaseStatus
    {
        Pass,
        Fail,
        Blocked,
        WP,
        Unexecuted
    };
    
    public static void Task5()
    {
        Console.WriteLine("\nFifth task:");
        
        // Создаем и выводим белый цвет
        RGB white = new RGB(255, 255, 255);
        Console.WriteLine("White: " + white);

        // Создаем и выводим черный цвет
        RGB black = new RGB(0, 0, 0);
        Console.WriteLine("Black: " + black);

        Console.ReadKey();
    }

    // Описываем структуру
    struct RGB
    {
        private byte red;
        private byte green;
        private byte blue;

        // конструктор
        public RGB(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        // переопределяем Метод ту стринг
        public override string ToString()
        {
            return $"R:{red},G:{green},B:{blue}";
        }

    }
}