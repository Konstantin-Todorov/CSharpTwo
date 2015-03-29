//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, ALULA , CIVIC , DAKED ,exe.
using System;
using System.Linq;
using System.Text.RegularExpressions;
class Palindromes
{
    static void Main()
    {
        Console.Write("Enter a text : ");
        string text = Console.ReadLine().ToLower();
        MatchCollection words = Regex.Matches(text, @"\b\w+\b");
        foreach (var word in words)
        {
            if (IsPalinome(word.ToString()))
            {
                Console.WriteLine("Palinom : {0}",word);
            }
        }
    }

    static bool IsPalinome(string word)
    {
        return word.ToCharArray().SequenceEqual(word.ToCharArray().Reverse());
    }
}
