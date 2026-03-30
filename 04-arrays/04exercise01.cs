using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Store 5 Numbers ——");
        Console.WriteLine("----------------------");
        Console.WriteLine();

        int[] numbers = new int[5];

        // INPUT
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter a number: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        // OUTPUT
        Console.WriteLine("Numbers entered:");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}