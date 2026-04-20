using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double grade = ReadValidDouble("Enter the grade: ");

        string status = GetStudentStatus(grade);

        Console.WriteLine("Status: " + status);
    }

    static double ReadValidDouble(string message)
    {
        double value; 
        bool isValid; 

        do
        {
            Console.Write(message);

            string input = Console.ReadLine();

            isValid = double.TryParse(
                input,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out value
            );

            if (!isValid)
            {
                Console.WriteLine("Invalid input. Try again.");
            }

        } while (!isValid); 

        return value;
    }

    static string GetStudentStatus(double grade)
    {
        if (grade >= 7)
        {
            return "Approved";
        }

        if (grade >= 5)
        {
            return "Recovery";
        }

        return "Failed";
    }
}