using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Password Strength Checker ——"); 
        Console.WriteLine("----------------------"); 
        Console.WriteLine();

        Console.Write("Enter a password: "); 
        string password = Console.ReadLine();

        if (password.Length < 6 )
        {
            Console.WriteLine("Your password is a weak");
        }
        else if (password.Length <= 10 )
        {
            Console.WriteLine("Your password is a medium");
        }
        else
        {
            Console.WriteLine("Your password is a strong");
        }
    }
}