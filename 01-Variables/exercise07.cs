using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Temperature Converter ——"); 
        Console.WriteLine("-------------------------"); 
        Console.WriteLine();

        Console.Write("Enter temperature in Celsius: ");
        double tempCelsius = double.Parse(Console.ReadLine());

        Console.WriteLine();

        double tempFahrenheit = (tempCelsius * 9/5) + 32;
        double tempKelvin = tempCelsius + 273.15;

        Console.WriteLine($"Celsius temperature: {tempCelsius:F2}");
        Console.WriteLine();
        Console.WriteLine($"Fahrenheit temperature: {tempFahrenheit:F2}");
        Console.WriteLine($"Kelvin temperature: {tempKelvin:F2}");
        

        
}
}