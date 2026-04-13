using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Read Array Method ——");
        Console.WriteLine("------------------------");
        Console.WriteLine();

        int[] numbers = ReadArray();

        Console.WriteLine();
        Console.WriteLine("Numbers entered:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    static int[] ReadArray()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter a number: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        return numbers;
    }
}