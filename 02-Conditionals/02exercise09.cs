using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Driver's License Checker ——"); 
        Console.WriteLine("----------------------"); 
        Console.WriteLine();

        Console.Write("Enter your age : "); 
        int inputAge = int.Parse(Console.ReadLine());
        
        Console.Write("Do you have a driver's license? true or false: "); 
        bool inputDriver = bool.Parse(Console.ReadLine());

        if (inputAge >= 18 && inputDriver )
        {
            Console.WriteLine("You Can drive.");
        }
        else
        {
            Console.WriteLine("You Cannot drive.");
        }
    }
}