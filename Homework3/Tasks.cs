namespace Homework3;

public static class Tasks
{
    public static void Task1()
    {
        Console.WriteLine("\nFirst task:");

        // Ввводим данные
        var num1 = MyUtilite.EnterValue<int>("Enter first number");
        var num2 = MyUtilite.EnterValue<int>("Enter second number");

        // Меняем местами что бы шли в порядке возрастания
        if (num1 > num2)
        {
            (num1, num2) = (num2, num1);
        }

        // Сичтаем ответ
        var ans = num2 / 3 - num1 / 3;
        if (num1 % 3 == 0) ans++;

        // Выводим ответ
        Console.WriteLine($"Numbers that divide by 3 in this interval: {ans}");
        
        Console.ReadKey();
    }
    
    public static void Task2()
    {
        Console.WriteLine("\nSecond task:");
        
        // Вводим строку
        var str = MyUtilite.EnterValue<string>("Enter your string");

        // Перебираем строку
        for (var i = 1; i < str.Length; i+=2)
            Console.WriteLine(str[i]);
        
        Console.ReadKey();
    }

    public static void Task3()
    {
        Console.WriteLine("\nThird task:");

        // Определяем словарь
        var Drinks = new Dictionary<string, int>()
        {
            { "coffee", 40 },
            { "tea", 20 },
            { "juice", 35 },
            { "water", 15 }
        };

        // Ввводим название с проверкой на корректность
        var enter = MyUtilite.EnterValue<string>("Enter name of the drink ( 'coffee', 'tea', 'juice', 'water' or 'skip') :", 
            check => check.ToLower() is "coffee" or "tea" or "juice" or "water" );
        enter = enter.ToLower();
        
        // Выводим ответ из словаря
        if(enter != "skip") Console.WriteLine($"Name: {enter}, Price: {Drinks[enter]}");
        
        Console.ReadKey();
    }
    
    public static void Task4()
    {
        Console.WriteLine("\nFourth task:");
        
        // Счетчики
        var sum = 0.0;
        var count = 0.0;
        
        Console.WriteLine("Enter the numbers. The numbers will be read until the first negative number!");
        while (true)
        {
            // Вводим числа
            var num = MyUtilite.EnterValue<int>("Number (always enter only 1 number):");
            
            if(num<0) break;
            
            // Считаем количество и сумму
            sum += num;
            count++;
        }

        // Считаем среднее
        var arg = sum / count;
        
        // Выводим ответ
        Console.WriteLine($"Average of all positive numbers up to the first negative number: {arg}");
        
        Console.ReadKey();
    }

    public static void Task5()
    {
        Console.WriteLine("\nFifth task:");
    
        // Вводим номер года
        var year = MyUtilite.EnterValue<int>("Enter your year:");
        
        // Проверяем и выводиим ответ
        Console.WriteLine(CheckLeap(year) ? "This year is a leap" : "This year is NOT a leap");

        Console.ReadKey();
    }

    public static bool CheckLeap(int year)
    {
        if (year % 400 == 0)
            return true;
        if (year % 100 == 0)
            return false;
        return year % 4 == 0;
    }
    
    public static void Task6()
    {
        Console.WriteLine("\nSixth task:");
        
        var num = MyUtilite.EnterValue<int>("Enter your number:");
        var sum = 0;

        // Считаем сумму цифр
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        
        // Выводим ответ
        Console.WriteLine($"The sum of the digits in this number: {sum}");
        
        Console.ReadKey();
    }
    
    public static void Task7()
    {
        Console.WriteLine("\nSeventh task:");

        var num = MyUtilite.EnterValue<int>("Enter your number:");
        var check = true;

        // Считаем сумму цифр
        while (num > 0)
        {
            if (num % 10 % 2 == 0)
            {
                check = false;
                break;
            }

            num /= 10;
        }
        
        // Выводим ответ
        Console.WriteLine(check ? $"There are only odd numbers in the number" : "There are paired numbers in a number");
        
        Console.ReadKey();
    }
}