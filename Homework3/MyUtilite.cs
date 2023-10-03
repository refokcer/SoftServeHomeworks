namespace Homework3;

public static class MyUtilite
{
    // Проверка на корректность ввода данных ( что бы ввели нужный тип данных )
    // + дополнительная проверка условия ( при необходимости )  при вводе
    public static T EnterValue<T>(in string text, IsTrue<T> func)
    {
        while (true)
        {
            // Оброботка ошибки ( конвертации )
            try
            {
                // Выводим сообщения что нужно ввессти
                Console.WriteLine(text);
                
                // Конвертируем в нужный нам тип данных 
                var check = (T)Convert.ChangeType(Console.ReadLine(), typeof(T))!;

                // Проверка дополнительного условия
                if (!func(check)) continue;
                
                // Возвращаем ввод если все коректно
                return check;
            }
            catch (Exception)
            {
                // Обраюатываем ошибку конвертации
                Console.WriteLine("Error. Please try again.");
            }
        }
    }

    // Если дополнительного условия проверки при вводе нету
    public static T EnterValue<T>(string text)
    {
        return EnterValue<T>(text, _ => true);
    }

    // Делегат для дополнительного условия
    public delegate bool IsTrue<in T>(T x);
}