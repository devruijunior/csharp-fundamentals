using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Find Max ——");
        Console.WriteLine("----------------");
        Console.WriteLine();

        Console.Write("How many numbers? ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = ReadArray(size);

        int max = FindMax(numbers);

        Console.WriteLine();
        Console.WriteLine("Max value: " + max);
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
    static int FindMax(int[] numbers)
    {
        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i]; 
            }
        }

        return max; 
    }
}