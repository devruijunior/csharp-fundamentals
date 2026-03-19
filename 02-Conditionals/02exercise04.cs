



using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Largest of Three Numbers ——"); 
        Console.WriteLine("----------------------"); 
        Console.WriteLine();

        Console.Write("Enter a first number: "); 
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Enter a second number: "); 
        int n2 = int.Parse(Console.ReadLine());

        Console.Write("Enter a third number: "); 
        int n3 = int.Parse(Console.ReadLine());

        if (n1 >= n2 && n1 >= n3 )
        {
            Console.WriteLine("The largest number is: "+n1 );
        }
        else if (n2 >= n1 && n2 >= n3)
        {
            Console.WriteLine("The largest number is: "+n2 );
        }
	else if (n3 >= n1 && n3 >= n2)
        {
            Console.WriteLine("The largest number is: "+n3 );
        }

        else
        {
            Console.WriteLine("Number invalid.");
        }

    }
}