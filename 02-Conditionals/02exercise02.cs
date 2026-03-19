using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Grade Evaluator ——"); 
        Console.WriteLine("----------------------"); 
        Console.WriteLine();

        Console.Write("Enter a student grade: "); 
        int number = int.Parse(Console.ReadLine());

        if (number >= 90 && number <= 100)
        {
            Console.WriteLine("Grade: A");
        }
        else if (number >= 80 && number <= 89)
        {
            Console.WriteLine("Grade: B");
        }
	else if (number >= 70 && number <= 79)
        {
            Console.WriteLine("Grade: C");
        }
	else if (number >= 60 && number <= 69)
        {
            Console.WriteLine("Grade: D");
        }
	else if (number >= 0 && number <= 59)
        {
            Console.WriteLine("Grade: F");
        }
        else
        {
            Console.WriteLine("Number invalid.");
        }

    }
}