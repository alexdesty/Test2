namespace Test2task5.Models;
internal class Person
{
    public string Name { get; set; }

    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

