using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— The Secret Number ——");
        Console.WriteLine("----------------------------");
        Console.WriteLine();

        int secretNumber = 7;
        int number;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        while (number != secretNumber)
        {
            if (number > secretNumber)
            {
                Console.WriteLine("Too high");
            }
            else
            {
                Console.WriteLine("Too low");
            }

            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("Correct!");
    }
}