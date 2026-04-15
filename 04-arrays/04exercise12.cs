using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Find Average ——");
        Console.WriteLine("-------------------");
        Console.WriteLine();

        Console.Write("How many numbers? ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = ReadArray(size);

        double average = FindAverage(numbers);

        Console.WriteLine();
        Console.WriteLine("Average: " + average);
    }

    // método reutilizado
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

    // 🔥 MÉTODO FINAL
    static double FindAverage(int[] numbers)
    {
        int soma = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            soma += numbers[i];
        }

        double average = (double)soma / numbers.Length;

        return average;
    }
}