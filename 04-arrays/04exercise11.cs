using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Find Min ——");
        Console.WriteLine("----------------");
        Console.WriteLine();

        Console.Write("How many numbers? ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = ReadArray(size);

        int min = FindMin(numbers);

        Console.WriteLine();
        Console.WriteLine("Min value: " + min);
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
    static int FindMin(int[] numbers)
    {
        int min = numbers[0]; 

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i]; 
            }
        }

        return min;
    }
}