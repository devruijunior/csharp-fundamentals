using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Triangle Type Checker ——"); 
        Console.WriteLine("----------------------"); 
        Console.WriteLine();

        Console.Write("Enter the first side:"); 
        int inputSide1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second side:"); 
        int inputSide2 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the third side:"); 
        int inputSide3 = int.Parse(Console.ReadLine());

        if (inputSide1 == inputSide2 && inputSide2 == inputSide3)
        {
            Console.WriteLine("Equilateral");
        }
        else if ((inputSide1 == inputSide2) || (inputSide2 == inputSide3) || (inputSide1 == inputSide3))
        {
            Console.WriteLine("Isosceles");
        }
        else
        {
            Console.WriteLine("Scalene");
        }
    }
}