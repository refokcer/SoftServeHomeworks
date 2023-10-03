using System.Data;

namespace Homework3;

public static class Homework
{
    public static void Task1()
    {
        Console.WriteLine("\nFirst task:");

        // Создаем словарь с буквами
        var leters = new Dictionary<char, int>()
        {
            {'a', 0},
            {'o', 0},
            {'i', 0},
            {'e', 0}
        };

        // Вводим строку
        var str = MyUtilite.EnterValue<string>("Enter your string");

        // Считаем количество a, o, i, e
        foreach (var t in str.Where(t => leters.ContainsKey(t))) leters[t]++;

        // Выводим отдельно каждую букву и суммируем все буквы
        var sum = 0;
        foreach (var pair in leters)
        {
            sum += pair.Value;
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
        
        // Всего гласных 
        Console.WriteLine($"Total: {sum}");

        Console.ReadKey();
    }
    
    public static void Task2()
    {
        Console.WriteLine("\nSecond task:");

        // Вводиим номер месяца
        var mm = MyUtilite.EnterValue<int>("Enter number of month (1-12):", check => check is >= 1 and <= 12);

        // Проверка на февраль и высокосный
        if (mm == 2)
        {
            var year = MyUtilite.EnterValue<int>("For info about days in this month enter year");
            Console.WriteLine(Tasks.CheckLeap(year) ? $"Days in {mm} month: {29}" : $"Days in {mm} month: {28}");
        }
        else
        {
            Console.WriteLine($"Days in {mm} month: {Days(mm)}");
        }

        Console.ReadKey();
    }

    // Количество дней по месяцу
    private static int Days(int mm)
    {
        return mm switch
        {
            1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
            4 or 6 or 9 or 11 => 30,
            _ => 0
        };
    }

    public static void Task3()
    {
        Console.WriteLine("\nThird task:");

        // объявляем все необходимые переменные 
        var nums = new int[10];
        var sum = 0;
        var product = 0;
        
        Console.WriteLine("Enter 10 number 1 by 1");

        // Вводим и сразу перебираем все числа
        for (var i = 0; i < 10; i++)
        {
            // Вводим значения
            nums[i] = MyUtilite.EnterValue<int>($"Enter {i+1} number:");
            // Проверяем значения для суммы
            if (i <= 4)
            {
                if (nums[i] < 0)
                {
                    sum = 0;
                    i = 4;
                    product = 1;
                }
                else
                {
                    sum += nums[i];
                }
            }
            else
            {
                product *= nums[i];
            }
        }
        
        Console.WriteLine($"sum: {sum}\n" +
                          $"product: {product}");
        
        Console.ReadKey();
    }
}