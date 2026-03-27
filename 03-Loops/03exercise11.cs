using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Average of the numbers ——");
        Console.WriteLine("----------------------------");
        Console.WriteLine();

        int total = 0;
        int count = 0;
        int number;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        while (number != 0)
        {
            if (number > 0)
            {
                total += number;
                count++;
            }

            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        if (count > 0)
        {
            double average = (double)total / count;
            Console.WriteLine("The average is: " + average);
        }
        else
        {
            Console.WriteLine("No valid numbers entered.");
        }
    }
}