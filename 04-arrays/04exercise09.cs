using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Sum Array ——");
        Console.WriteLine("----------------");
        Console.WriteLine();

        
        Console.Write("How many numbers? ");
        int size = int.Parse(Console.ReadLine());

        
        int[] numbers = ReadArray(size);

        
        int total = SumArray(numbers);

        
        Console.WriteLine();
        Console.WriteLine("Sum: " + total);
    }
    static int[] ReadArray(int length)
    {
        int[] numbers = new int[length];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter a number: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        return numbers;
    }

    static int SumArray(int[] numbers)
    {
        int soma = 0; 

        for (int i = 0; i < numbers.Length; i++)
        {
            soma += numbers[i]; 
        }

        return soma; 
    }
}