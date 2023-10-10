namespace Homework6;

public class Task6_3 : ITask
{
    public static void Execute()
    {
        // Начальные значения
        var start = 1;
        var end = 100;

        // Лист чисел
        var nums = new List<int>();
        
        // Ввод 10 цифр последовательно при это двигаем левую границу
        for (var i = 0; i < 10; i++)
        {
            var num = ReadNumber(start, end, 10 - i);
            
            nums.Add(num);
            
            start = num;
        }
        
        // Выводим ответ
        MyUtilite.Output(nums);
    }

    private static int ReadNumber(in int start, in int end, in int iter)
    {
        // Мое решение с помощью моей утилиты
        // Создаем локально переменные что бы передать в мою функцию в люмбду
        var start1 = start;
        var end1 = end;
        var iter1 = iter;
        var errorMessage = "";
        
        // Моя утилита с перебором, проверкой на тип данных и дополнительной проверкой на нужное нам условие
        var num = MyUtilite.EnterValue<int>("Enter an integer:", check =>
        {
            if(check <= start1)
                errorMessage = $"Your number must be greater than {start1}!";
            else if(check >= end1 - iter1 + 1)
                errorMessage = $"Your number must be less than {end1 - iter1 + 1}, that we could enter all numbers according to the rule";
            else return true;
            
            return false;
        }, errorMessage);
        
        // Все выполниться четко по заданию
        // var num = MyUtilite.EnterValue<int>("Enter an integer:");
        //
        // if (num <= start)
        //     throw new Exception("Your number must be greater than {start}!");
        // if(num >= end - iter + 1)
        //     throw new Exception($"Your number must be less than {end - iter + 1}, that we could enter all numbers according to the rule");
        
        // Возвращаем корректную цифру
        return num;
    }
}