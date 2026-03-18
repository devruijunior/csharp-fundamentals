using System;

class Program
{
static void Main()
{
Console.WriteLine("—— Currency Converter USD → BRL → EUR ——");
Console.WriteLine("------------------------------------------");
Console.WriteLine();

Console.Write("Enter amount in USD: ");
double amountUsd = double.Parse(Console.ReadLine());

Console.Write("Enter USD to BRL exchange rate: ");
double brlRate = double.Parse(Console.ReadLine());

Console.Write("Enter USD to EUR exchange rate: ");
double eurRate = double.Parse(Console.ReadLine());

Console.WriteLine();

double amountBrl = amountUsd * brlRate;
double amountEur = amountUsd * eurRate;
double brlToEur = (amountBrl / brlRate) * eurRate;

Console.WriteLine("Results:\n");

Console.WriteLine($"USD: {amountUsd:F2}");
Console.WriteLine($"BRL: {amountBrl:F2}");
Console.WriteLine($"EUR: {amountEur:F2}");
Console.WriteLine($"BRL → EUR: {brlToEur:F2}");
}
}