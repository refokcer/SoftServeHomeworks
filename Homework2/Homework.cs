namespace Homework2;

public static class Homework
{
    public static void Task1()
    {
        Console.WriteLine("\nFirst task:");

        // Переменная для проверки
        var check = true;
        
        // Ввод в цикле что бы легко можно было увеличить количество проверяемых чисел
        for (var i = 0; i < 3; i++)
        {
            var number = MyUtilite.EnterValue<float>($"Enter {i+1} number:");
            if (number <= -5.0 || number >= 5.0) check = false;
        }

        // Выводим ответ
        Console.WriteLine(check
            ? "All numbers are between -5 and 5."
            : "At least one of the numbers does not lie between -5 and 5");
        
        // Ожидаем действие
        Console.ReadKey();
    }
    
    public static void Task2()
    {
        Console.WriteLine("\nSecond task:");

        // Вводим первое число
        var num1 = MyUtilite.EnterValue<int>("Enter first number:");

        // присваеваем первое число как мин и макс что бы запустиить коректно цикл
        var min = num1;
        var max = num1;

        // Вводим через цикл что бы можно было легко уыеличить количество цифр
        for (var i = 1; i < 3; i++)
        {
            var num = MyUtilite.EnterValue<int>($"Enter {i + 1} number");
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }
        
        // Выводим ответ
        Console.WriteLine($"Min number: {min}; \nMax number: {max}");

        Console.ReadKey();
    }

    public static void Task3()
    {
        Console.WriteLine("\nThird task:");

        // Вводим значение ошбки в пределах 400 - 406
        var numOfError = MyUtilite.EnterValue<int>("Enter number of Http error (400 - 406)",  check => check is >= 400 and <= 406);
        
        // Выводим название ошибки
        Console.WriteLine((HTTPError)numOfError);

        Console.ReadKey();
    }   

    enum HTTPError
    {
        Bad_Request = 400,
        Unauthorized = 401,
        Payment_Required = 402,
        Forbidden = 403,
        Not_Found = 404,
        Method_Not_Allowed = 405,
        Not_Acceptable = 406
    }
    
    public static void Task4()
    {
        Console.WriteLine("\nForth task:");

        // Создаем собаку с клавиатуры
        var myDog = Dog.DogFromConsole();
        
        // Выводим инфо про собаку
        Console.WriteLine(myDog);

        Console.ReadKey();
    }

    
    private struct Dog
    {
        private string name;
        private string mark;
        private int age;

        // Конструктор для ввода с клавиатуры
        public static Dog DogFromConsole()
        {
            var Name = MyUtilite.EnterValue<string>("Enter the name of the dog:");
            var Mark = MyUtilite.EnterValue<string>("Enter the mark if the dog:");
            var Age = MyUtilite.EnterValue<int>("Enter the age of the god");

            return new Dog(Name, Mark, Age);
        }

        
        private Dog(string name, string mark, int age)
        {
            this.name = name;
            this.mark = mark;
            this.age = age;
        }

        public override string ToString()
        {
            return "Info about dog:\n" +
                   $"Name: {name}\n" +
                   $"Mark: {mark}\n" +
                   $"Age: {age}";
        }
    }
}