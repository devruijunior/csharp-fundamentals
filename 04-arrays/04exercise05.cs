using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Reverse Array ——");
        Console.WriteLine("---------------------------------");
        Console.WriteLine();

        int[] numbers = new int[5];

        // INPUT (normal)
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter a number: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("Numbers in reverse:");

        // OUTPUT (invertido)
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}