using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Fuel Consumption Calculator ——"); 
        Console.WriteLine("-------------------------"); 
        Console.WriteLine();

        Console.Write("Enter distance traveled (km): ");
        double distanceTraveled = double.Parse(Console.ReadLine());
        Console.Write("Enter fuel used (liters): ");
        double fuelUsed = double.Parse(Console.ReadLine());
        Console.Write("Enter Fuel price per liter: ");
        double fuelPrice = double.Parse(Console.ReadLine());
       
        Console.WriteLine();
        
        double consumption = distanceTraveled / fuelUsed;
        double costPerKm = fuelPrice / consumption;

        Console.WriteLine();

        Console.WriteLine($"Your fuel consumption is: {consumption:F2} km per liter");
        Console.WriteLine($"Your cost per km is: {costPerKm:F2} USD$");

        
}
}