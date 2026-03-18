using System;

class Program
{
static void Main()
{
Console.WriteLine("—— Age in Days and Hours Calculator ——");
Console.WriteLine("---------------------------------------");
Console.WriteLine();

Console.Write("Enter your age in years: ");
int ageYears = int.Parse(Console.ReadLine());

Console.Write("Enter additional months: ");
int months = int.Parse(Console.ReadLine());

Console.Write("Enter additional days: ");
int days = int.Parse(Console.ReadLine());

Console.WriteLine();

int totalDays = (ageYears * 365) + (months * 30) + days;
int totalHours = totalDays * 24;

Console.WriteLine("Results:\n");

Console.WriteLine($"You have lived approximately {totalDays} days.");
Console.WriteLine($"You have lived approximately {totalHours} hours.");
}
}