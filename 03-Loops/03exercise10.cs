using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Find the largest number ——");
        Console.WriteLine("----------------------------");
        Console.WriteLine();

        int largestNumber;
        int number;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        largestNumber = number;

        while (number != 0)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }

            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("The largest number is: " + largestNumber);
    }
}