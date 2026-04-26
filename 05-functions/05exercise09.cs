using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();

        int vowelCount = CountVowels(text);

        Console.WriteLine("Vowels: " + vowelCount);
    }

    static int CountVowels(string text)
    {
        int count = 0;

        text = text.ToLower();

        foreach (char c in text)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                count++; 
            }
        }

        return count;
    }
}