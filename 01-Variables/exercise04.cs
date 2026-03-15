
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Developer Profile ——"); 
        Console.WriteLine("-------------------------"); 
        Console.WriteLine();


        Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
        Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
        Console.Write("Enter your City: ");
            string city = Console.ReadLine();
        Console.Write("Enter your Profession: ");
            string profession = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("City: " + city);
        Console.WriteLine("Profession: " + profession);
        
        int ageFut = age + 10;
        Console.WriteLine("You will be "+ ageFut + " years old in 10 years.");  
 
    }
}