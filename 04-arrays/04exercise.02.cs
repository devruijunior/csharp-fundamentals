using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Find Largest Number (Array) ——");
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
        int largest = numbers[0];

        for (int i = 1; i < 5; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }

        // OUTPUT
        Console.WriteLine();
        Console.WriteLine("Largest number = " + largest);
    }
}