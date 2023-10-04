using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace Homework4;

public class Person
{
    // a) two private fields: name and birthYear (the birthday year). (As a type for this field you may use DataTime type.)
    private string _name;
    private DateTime _birthDate;

    // b) two properties for access to these fields (can use only get)
    public string Name => _name;
    public DateTime BirthYear => _birthDate;

    // c) default constructor and constructor with 2 parameters 
    public Person()
    {
        _name = "";
        _birthDate = new DateTime(2005, 1, 22);
    }

    public Person(string name, DateTime birthDate)
    {
        _name = name;
        _birthDate = birthDate;
    }

    // d) methods:
    
    // Age() - to calculate the age of person
    public void Age()
    {
        var dateTimeToday = DateTime.Today;
        var difference = dateTimeToday.Subtract(_birthDate);

        // Первый день из-за того что difference это TimeSpan и на прямую можем получть только количество дней
        var firstDay = new DateTime(1, 1, 1);

        // Считаем количество лет месяцев и дней
        var years = (firstDay + difference).Year - 1;
        var months = (firstDay + difference).Month - 1;
        var days = (dateTimeToday - _birthDate.AddMonths((years * 12) + months)).Days;

        Console.WriteLine($"Age is {years} years, {months} months, {days} days");
    }

    // - Input() - to enter data about person from console
    public static Person Input()
    {
        var name = MyUtilite.EnterValue<string>("Enter the name of the Person:");
        var birthDate =
            MyUtilite.EnterValue<DateTime>("Enter the date of birthday of the Person in format 'dd.mm.yyyy'");

        return new Person(name, birthDate);
    }

    // - ChangeName() - to change the name of person
    public void ChangeName(string name) => _name = name;

    // - ToString() 
    public override string ToString() => $"Info about person: Name: {_name}, Date of birthday: {_birthDate}";
    
    //  Output() - to output information about person (call ToString())
    public void Output() => Console.WriteLine(ToString());
        
    // - operator== (equal by name)
    public static bool operator ==(Person first, Person second) => first._name == second._name;
    public static bool operator !=(Person first, Person second) => !(first == second);
    
    
}