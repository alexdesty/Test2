namespace Test2Task4.Models;
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public event Action<string> OnCompleted;

        private static int _count = 0;
    public Person(string name, int age) 
    {
        Name = name;
        Age = age;
    }

        public void Method()
        {
            _count++;
        Console.Write($"Hello. My name is {this.Name}");
            if (_count % 10 == 0)
            {
                OnCompleted?.Invoke($" I'm {this.Age} years old");
            }
        Console.WriteLine();
        }
    }

