using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Sum Until Zero ——");
        Console.WriteLine("---------------------");
        Console.WriteLine();

        int total = 0;
        int number;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        while (number != 0)
        {
            if (number >= 0)
            {
                total += number;
            }
            else
            {
                Console.WriteLine("We can't add negative numbers.");
            }

            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("Total = " + total);
    }
}
