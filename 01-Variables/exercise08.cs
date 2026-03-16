using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— BMI Calculator ——"); 
        Console.WriteLine("-------------------------"); 
        Console.WriteLine();

        Console.Write("Enter your weight (kg): ");
        double weight = double.Parse(Console.ReadLine());
        Console.Write("Enter your height (M): ");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine();
        // BMI = weight / Math.Pow(height, 2) add formule
        double heightSquared = height * height;
        double BMI = weight / heightSquared;
        Console.WriteLine();

        Console.WriteLine($"Height squared: {heightSquared:F2}");
        Console.WriteLine($"Your BMI is: {BMI:F2}");
   
        
}
}