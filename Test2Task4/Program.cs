using Test2Task4.Models;

namespace Test2Task4;
internal class Program
{
    static void Main(string[] args)
    {
        var person1 = new Person("Jack",22);
        var person2 = new Person("Anna", 23);
        var person3 = new Person("Michael", 24);
        person1.OnCompleted += msg => Console.Write(msg);
        person2.OnCompleted += msg => Console.Write(msg);
        person3.OnCompleted += msg => Console.Write(msg);
        person1.Method();
        person2.Method();
        person3.Method();
        person1.Method();
        person2.Method();
        person3.Method();
        person1.Method();
        person2.Method();
        person3.Method();
        person1.Method();
        person2.Method();
        person3.Method();
        person1.Method();
        person2.Method();
        person3.Method();
        person1.Method();
        person2.Method();
        person3.Method();
        person1.Method();
        person2.Method();
        person3.Method();
    }
}

