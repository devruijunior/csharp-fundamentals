using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Discount Calculator ——"); 
        Console.WriteLine("--------------------------"); 
        Console.WriteLine();

        Console.Write("Enter purchase amount: "); 
        double purchaseAmount = double.Parse(Console.ReadLine());

        double discountRate = 0;

        if (purchaseAmount >= 1000)
        {
            discountRate = 0.20;
        }
        else if (purchaseAmount >= 500)
        {
            discountRate = 0.10;
        }
        else if (purchaseAmount >= 100)
        {
            discountRate = 0.05;
        }
        else
        {
            discountRate = 0;
        }

        double discount = purchaseAmount * discountRate;
        double finalPrice = purchaseAmount - discount;

        Console.WriteLine($"Discount: {discountRate * 100}%");
        Console.WriteLine($"Final price: {finalPrice:F2}");
    }
}