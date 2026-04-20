using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Calculate average ——");
        Console.WriteLine("------------------------");
        Console.WriteLine();

        double grade1 = ReadValidDouble("Enter first grade: ");
        double grade2 = ReadValidDouble("Enter second grade: ");

        double average = CalculateAverage(grade1, grade2);

        Console.WriteLine("Average: " + average);
    }

    // Função responsável por ler um número válido do usuário
    static double ReadValidDouble(string message)
    {
        double value;
        bool isValid;

        do
        {
            Console.Write(message);
            string input = Console.ReadLine();

            isValid = double.TryParse(input, out value);

            if (!isValid)
            {
                Console.WriteLine("Invalid input. Try again.");
            }

        } while (!isValid);

        return value;
    }

    // Função responsável apenas pelo cálculo da média
    static double CalculateAverage(double grade1, double grade2)
    {
        return (grade1 + grade2) / 2;
    }
}