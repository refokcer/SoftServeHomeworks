namespace Homework2;

public static class AdditionalTasks
{
    public static void Task1()
    {
        Console.WriteLine("\nFirst task:");

        var cat = new Cat();
        
        // По очереди кушаем разную еду
        cat.EatSomething(Food.Feed);
        Console.WriteLine(cat);
        
        cat.EatSomething(Food.Mouse);
        Console.WriteLine(cat);
        
        cat.EatSomething(Food.Fish);
        Console.WriteLine(cat);

        Console.ReadKey();
    }

    // Класс котв
    private class Cat
    {
        // Сытность
        private int _fullnessLevel;
         
        // Конструктор
        public Cat()
        {
            _fullnessLevel = 0;
        }

        // Метод для еды
        public void EatSomething(Food food)
        {
            _fullnessLevel += (int)food;
        }
        
        // Для вывода
        public override string ToString()
        {
            return $"Fullness level: {_fullnessLevel}";
        }
    }
    
    // Перечесление еды
    private enum Food
    {
        Feed = 1,
        Fish = 3,
        Mouse = 5
    }
    
    public static void Task2()
    {
        Console.WriteLine("\nSecond task:");

        var students = new Student[4];

        // Ввод студентов
        for (var i = 0; i < 4; i++)
        {
            Console.WriteLine($"Enter info about {i+1} student");
            students[i] = Student.StudentInputFromConsole();
        }
        
        // Поиск студента по группе
        var groupForSearch = MyUtilite.EnterValue<int>("Enter the group to search");
        
        Console.WriteLine($"Students in {groupForSearch}:");

        var check = true;
        for (var i = 0; i < 4; i++)
        {
            if (students[i].group == groupForSearch)
            {
                Console.WriteLine(students[i]);
                check = false;
            }
        }

        if (check) Console.WriteLine("There are no students in this group");

        Console.ReadKey();
    }

    private struct Student
    {
        private string _name;
        public int group { get; }

        public static Student StudentInputFromConsole()
        {
            var name = MyUtilite.EnterValue<string>("Enter last name of student");
            var Group = MyUtilite.EnterValue<int>("Enter group of the student");

            return new Student(name, Group);
        }

        private Student(string name, int group)
        {
            _name = name;
            this.group = group;
        }

        public override string ToString()
        {
            return $"Name: {_name}, Group: {group}";
        }
    }
    
}