using System;

class Program
{
static void Main()
{
Console.WriteLine("—— Simple Interest Calculator ——");
Console.WriteLine("-------------------------------");
Console.WriteLine();

Console.Write("Enter Initial capital: ");
double initialCapital = double.Parse(Console.ReadLine());

Console.Write("Enter Interest rate (%): ");
double interestRate = double.Parse(Console.ReadLine());

Console.Write("Enter Time (years): ");
double timeYears = double.Parse(Console.ReadLine());

Console.WriteLine();

double rate = interestRate / 100;

double interest = initialCapital * rate * timeYears;
double finalAmount = initialCapital + interest;
double monthlyInterest = interest / (timeYears * 12);

Console.WriteLine("Results:\n");

Console.WriteLine($"Interest earned: {interest:F2}");
Console.WriteLine($"Monthly interest: {monthlyInterest:F2}");
Console.WriteLine($"Final amount: {finalAmount:F2}");
}
}