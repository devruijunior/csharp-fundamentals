using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Counter up to 5 ——"); 
        Console.WriteLine("----------------------"); 
        Console.WriteLine();

        int contador = 1;

        while (contador <= 5)
        {
                Console.WriteLine(contador);
                contador++;
        }
    }
}