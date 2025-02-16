namespace Test2Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 3, 5, -10, 8, 11, 6 };
            Console.WriteLine("Collection:");
            foreach (var i in numbers)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            var result = numbers
                .OrderBy(n => n)
                .Skip((numbers.Count + 1) / 2) 
                .Select(n => n * n) 
                .OrderByDescending(n => n) 
                .ToList();
            Console.WriteLine("Sorted collection:");
            foreach (var i in result)
            {
                Console.Write(i + " ");
            }
        }
    }
}

