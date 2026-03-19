using System;

class Program
{
static void Main()
{
Console.WriteLine("—— Number Analyzer ——");
Console.WriteLine("----------------------");
Console.WriteLine();

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

if (number > 0)
{
Console.WriteLine("The number is positive.");
}
else if (number < 0)
{
Console.WriteLine("The number is negative.");
}
else
{
Console.WriteLine("The number is zero.");
}

if (number % 2 == 0)
{
Console.WriteLine("The number is even.");
}
else
{
Console.WriteLine("The number is odd.");
}
}
}