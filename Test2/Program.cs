namespace Test2;
internal class Program
{
    static void Main(string[] args)
    {
        var array = new int[4, 4];
        var rnd = new Random();
        Console.WriteLine("Array before editing:");
        for (var i = 0; i < array.GetUpperBound(0) + 1; i++)
        {
            for (var j = 0; j < array.GetUpperBound(1) + 1; j++)
            {
                array[i, j] = rnd.Next(10);
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (var i = 0; i < array.GetUpperBound(0) + 1; i++)
        {
            for (var j = i + 1; j < array.GetUpperBound(1) + 1; j++)
            {
                array[i, j] = 1;
            }
        }
        Console.WriteLine("Array after editing:");
        for (var i = 0; i < array.GetUpperBound(0) + 1; i++)
        {
            for (var j = 0; j < array.GetUpperBound(1) + 1; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

