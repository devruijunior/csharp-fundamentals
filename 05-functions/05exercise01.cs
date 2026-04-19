using System;

class Program
{
    static void Main()
    {

        int resultado = Somar(5, 3);

        Console.WriteLine(resultado);
    }

    static int Somar(int a, int b)
    {
        int soma = a + b;

        return soma;
    }
}