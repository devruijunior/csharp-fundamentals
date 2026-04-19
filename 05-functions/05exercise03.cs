using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        string result = CheckEvenOrOdd(number);

        Console.WriteLine(result);
    }

    static string CheckEvenOrOdd(int number)
    {
        if (number % 2 == 0)
        {
            return "Even";
        }
        else
        {
            return "Odd";
        }
    }
}