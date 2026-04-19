using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Check positive number ——");
        Console.WriteLine("---------------------------");
        Console.WriteLine();

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool isPositive = IsPositive(number);

        Console.WriteLine(isPositive ? "Positive" : "Not positive");
    }
    static bool IsPositive(int number)
    {

        return number > 0;
    }
}