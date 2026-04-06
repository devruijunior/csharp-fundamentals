using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Above average ——");
        Console.WriteLine("---------------------------------");
        Console.WriteLine();

        int[] numbers = new int[5];

        // INPUT
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter a number: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // PROCESS
        int soma = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            soma += numbers[i];
        }

        double average = (double)soma / numbers.Length;

        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > average)
            {
                count++;
            }
        }

        // OUTPUT
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Above average: " + count);
    }
}