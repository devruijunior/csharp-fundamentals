using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Even and Odd Counters ——");
        Console.WriteLine("----------------------------");
        Console.WriteLine();

        int even = 0;
        int odd = 0;
        int number;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        while (number != 0)
        {
            if (number < 0)
            {
                Console.WriteLine("We can't count negative numbers.");
            }
            else if (number % 2 == 0)
            {
                even++;
            }
            else
            {
                odd++;
            }

            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("Total Even = " + even);
        Console.WriteLine("Total Odd = " + odd);
    }
}
