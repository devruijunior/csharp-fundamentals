using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Counter per user input ——"); 
        Console.WriteLine("----------------------"); 
        Console.WriteLine();

        Console.Write("Enter Up to what number will we count: "); 
        int numberCont = int.Parse(Console.ReadLine());
        if (numberCont <=0)
        {
            Console.WriteLine("Invalid number.");
            return;
        }

        int contador = 1;

        while (contador <= numberCont)
        {
                Console.WriteLine(contador);
                contador++;
        }
    }
}