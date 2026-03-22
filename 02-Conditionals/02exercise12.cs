using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Simple Calculator ——"); 
        Console.WriteLine("----------------------"); 
        Console.WriteLine();

        Console.Write("Enter the first number: "); 
        double number1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: "); 
        double number2 = double.Parse(Console.ReadLine());
        
        Console.Write("Enter the operator (+, -, *, /): "); 
        string inputOperator = Console.ReadLine();

        if (inputOperator == "+")
        {
            double result = number1 + number2;
            Console.WriteLine($"Result: {result}");
        }
        else if (inputOperator == "-")
        {
            double result = number1 - number2;
            Console.WriteLine($"Result: {result}");
        }
        else if (inputOperator == "*")
        {    
            double result = number1 * number2;
            Console.WriteLine($"Result: {result}");
        }
        else if (inputOperator == "/")
        {
            if (number2 == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            else
            {
                double result = number1 / number2;
                Console.WriteLine($"Result: {result}");
            }
        }
        else
        {
            Console.WriteLine("Invalid operator");
        }
    }
}