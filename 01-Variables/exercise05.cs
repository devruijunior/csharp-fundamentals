
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Simple Math Tool ——"); 
        Console.WriteLine("-------------------------"); 
        Console.WriteLine();


        Console.Write("Enter first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int number2 = int.Parse(Console.ReadLine());
  
        Console.WriteLine();
        //Console.WriteLine($"Sum: {sum}"); (usar interpolação de string da proxima vez)
        int sum = number1 + number2;
        int subtraction = number1 - number2;
        int multiplication = number1 * number2;
        int division = number1 / number2;
        int average = (number1 + number2) / 2;

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Subtraction: " + subtraction);
        Console.WriteLine("Multiplication: " + multiplication);
        Console.WriteLine("Division: " + division);
        Console.WriteLine("Average: " + average);
        
 
    }
}