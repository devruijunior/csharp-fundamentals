using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        int currentYear = 2026;
        int birthYear = currentYear - age;

        Console.WriteLine("You were born around: " + birthYear);
    }
}