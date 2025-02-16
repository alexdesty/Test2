using Test2task5.Models;

namespace Test2task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Registry<Person> registry1 = new Registry<Person>();
            Registry<Animal> registry2 = new Registry<Animal>();
            Person person1 = new Person("Jack", 22);
            Person person2 = new Person("Anna", 23);
            Animal animal2 = new Animal("Cat", 4);
            Animal animal1 = new Animal("Dog", 5);
            registry2.Add(animal1);
            registry2.Add(animal2);
            registry1.Add(person1);
            registry1.Add(person2);
            Console.WriteLine("List before remove items:");
            foreach (var item in registry1.GetAllItems())
            {
                item.ShowInfo();
            }
            foreach (var item in registry2.GetAllItems())
            {
                item.ShowInfo();
            }
            registry1.RemoveItem(person1);
            registry2.RemoveItem(animal1);
            Console.WriteLine("List after remove items:");
            foreach (var item in registry1.GetAllItems())
            {
                item.ShowInfo();
            }
            foreach (var item in registry2.GetAllItems())
            {
                item.ShowInfo();
            }

        }
    }
}

