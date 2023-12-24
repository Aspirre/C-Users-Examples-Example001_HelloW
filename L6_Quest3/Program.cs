using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "домик";

        bool isPalindrome = IsPalindrome(input);

        Console.WriteLine(isPalindrome ? "Yes" : "No");
    }

    static bool IsPalindrome(string str)
    {
        string normalized = new
        string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();

        return normalized.SequenceEqual(normalized.Reverse());
    }
}