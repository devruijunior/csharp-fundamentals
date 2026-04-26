using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();

        string reversed = ReverseText(text);

        Console.WriteLine("Reversed: " + reversed);
    }

    static string ReverseText(string text)
    {
        string result = "";

        for (int i = text.Length - 1; i >= 0; i--)
        {
            result += text[i];
        }

        return result;
    }
}