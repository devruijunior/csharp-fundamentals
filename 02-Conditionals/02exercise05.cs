using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Simple Login System ——"); 
        Console.WriteLine("---------------------------"); 
        Console.WriteLine();

        string correctUser = "admin";
        string correctPassword = "1234";

        Console.Write("Enter your username: "); 
        string inputUserName = Console.ReadLine();

        Console.Write("Enter your password: "); 
        string inputPassword = Console.ReadLine();

        if (inputUserName == correctUser && inputPassword == correctPassword) 
        {
            Console.WriteLine("Login successful.");
        }
        else
        {
            Console.WriteLine("Invalid username or password.");
        }
    }
}