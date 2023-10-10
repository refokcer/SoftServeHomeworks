namespace Homework6;

public class Task6_1 : ITask
{
    public static void Execute()
    {
        // Это задание можно сделать с  помощью моей утилиты
        // и быть увереным что нам не прилетит во вторую цифру 0 написав:
        // var num2 = MyUtilite.EnterValue<int>("Enter second number:", check => check == 0, "We can`t divide by 0!");
        
        // Enter our values
        // Так как у меня типизированя функция то в ней проверяется на ввод что бы вводились только значения этого типа
        // Там так же используется Try Catch ( Вроде как это сразу решение 5_2 )
        var num1 = MyUtilite.EnterValue<int>("Enter your first number:");
        var num2 = MyUtilite.EnterValue<int>("Enter your second number:");

        // Calculate with our func
        var ans = Div(num1, num2);
        
        // Output our result
        Console.WriteLine(ans == null ? "We can`t divide by 0!" : $"num1 / num2 = {ans};");
    }

    // Divide and try catch exception
    private static int? Div(int a, int b)
    {
        int ans;
        
        try
        {
            ans = a / b;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
        
        // Console.WriteLine("????");
        return ans;
    }
}