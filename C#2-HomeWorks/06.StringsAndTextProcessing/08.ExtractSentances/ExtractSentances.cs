//Write a program that extracts from a given text all sentences containing given word.
//Example:

//The word is: in

//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

//Consider that the sentences are separated by . and the words – by non-letter symbols.
using System;
using System.Text.RegularExpressions;
class ExtractSentances
{
    static void Main()
    {
        Console.Write("Enter text : ");
        string text = Console.ReadLine();
        Console.Write("Enter a word that you want to be contained by the secntences in the text : ");
        string wordKey = Console.ReadLine();
        string[] sentances = text.Split(new[] { '.' },StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < sentances.Length; i++)
        {
            if (SentancesContainigWordKey(sentances,i,wordKey))
            {
                Console.Write(sentances[i].Trim() + ".");
            }
        }
        Console.WriteLine();
    }

    static bool SentancesContainigWordKey(string[] sentances, int i, string wordKey)
    {
        return Regex.Matches(sentances[i], string.Format(@"\b{0}\b", wordKey) , RegexOptions.IgnoreCase).Count != 0;
    }
}

