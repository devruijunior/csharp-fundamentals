using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Read Array Method ——");
        Console.WriteLine("------------------------");
        Console.WriteLine();

        Console.Write("How many numbers? ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = ReadArray(size);

        Console.WriteLine();
        Console.WriteLine("Numbers entered:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    static int[] ReadArray(int length)
    {
        int[] numbers = new int[length];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter a number: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        return numbers;
    }
}