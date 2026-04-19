using System;

class Program
{
    static void Main()
    {

        Console.Write("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int result = Sum(firstNumber, secondNumber);

        Console.WriteLine("Result: " + result);
    }
    static int Sum(int a, int b)
    {
        return a + b;
    }
}