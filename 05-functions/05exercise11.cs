using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a text: ");
        string text = Console.ReadLine() ?? ""; 
        bool isPalindrome = IsPalindrome(text);

        Console.WriteLine(isPalindrome);
    }

    static bool IsPalindrome(string text)
    {
        string normalizedText = text.ToLower();

        string reversedText = ReverseText(normalizedText);

        return normalizedText == reversedText;
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