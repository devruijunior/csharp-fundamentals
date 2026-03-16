using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Circle Calculator ——"); 
        Console.WriteLine("-------------------------"); 
        Console.WriteLine();

        Console.Write("Enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());

        Console.WriteLine();
        
        double radiusSquared = radius * radius;
        double diameter = radius * 2;
        double circumference = 2 * Math.PI * radius;
        double area = Math.PI * radiusSquared;

        Console.WriteLine();

        Console.WriteLine($"Radius: {radius:F2}");
        Console.WriteLine($"Radius Squared: {radiusSquared:F2}");
        Console.WriteLine($"Diameter: {diameter:F2}");
        Console.WriteLine($"Circumference: {circumference:F2}");
        Console.WriteLine($"Area: {area:F2}");
   
        
}
}