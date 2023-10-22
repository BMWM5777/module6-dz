using System;
using MyLibrary;

class Program
{
    static void Main()
    {
        Person person = new Person
        {
            FirstName = "Connor",
            LastName = "McGregor",
            Age = 25
        };

        string personInfo = PersonUtility.GetPersonInfo(person);
        Console.WriteLine(personInfo);
    }
}
