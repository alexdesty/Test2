namespace Test2task5.Models;
internal class Animal
{
    public string AnimalName { get; set; }

    public int AnimalAge { get; set; }

    public Animal(string animalName, int animalAge)
    {
        AnimalName = animalName;
        AnimalAge = animalAge;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Animal Name:{AnimalName}, Animal Age: {AnimalAge}");
    }
}

