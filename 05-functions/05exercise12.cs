using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int sum = SumUpTo(number);

        Console.WriteLine("Sum: " + sum);
    }

    static int SumUpTo(int number)
    {
         int sum = 0;

        for (int i = 1; i <= number; i++)
        {
            sum += i;
        }
    return sum;
    }
}