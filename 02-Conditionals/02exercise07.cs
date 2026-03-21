using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Leap Year ——"); 
        Console.WriteLine("----------------------"); 
        Console.WriteLine();

        Console.Write("Enter a year: "); 
        int inputYear = int.Parse(Console.ReadLine());

        if ((inputYear % 4 == 0 && inputYear % 100 != 0) || (inputYear % 400 == 0))
        {
            Console.WriteLine($"{inputYear} is a leap year");
        }
        else
        {
            Console.WriteLine($"{inputYear} is not a leap year");
        }
    }
}