namespace Homework5;

public static class Task5_3
{
    public static void Execute()
    {
        // Create list of IPhone objects
        var list = new List<IPhone>()
        {
            new MobilePhone("1", 50),
            new RadioPhone("2", true, 90),
            new RadioPhone("3", false, 70),
            new RadioPhone("4", true, 940),
            new MobilePhone("5", 74),
            new MobilePhone("6", 84),
            new MobilePhone("7", 4),
        };
        
        // Sorting this list
        list.Sort();
        
        // Output list
        MyUtilite.Output(list);

        // Output only RadioPhones with Autoresponder
        OutputRadioPhonesWithAutoresponder(list);
    }

    private static void OutputRadioPhonesWithAutoresponder(List<IPhone> list)
    {
        foreach (var item in list)
        {
            // Проверяем на то что бы это был не мобильный телефон
            if (item is RadioPhone { IsAutoresponder: true } radioPhone)
                Console.WriteLine($"Radiophone with name {radioPhone.Name} have autoresponder");
            // else
            //     Console.WriteLine("This is mobile phone");
        }
    }
}