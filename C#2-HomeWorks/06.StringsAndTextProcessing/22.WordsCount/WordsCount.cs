//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class WordsCount
{
    static void Main()
    {
        Console.Write("Enter a text : ");
        string text = Console.ReadLine().ToLower();
        MatchCollection words = Regex.Matches(text, @"\b\w+\b");
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach (var word in words)
        {
            if (!dict.ContainsKey(word.ToString()))
            {
                dict.Add(word.ToString(), 1);
            }
            else
            {
                dict[word.ToString()]++;
            }
        }
        Console.WriteLine("Occurrence of words : \n{0}",
                                string.Join("\n",dict.Select(w => string.Format("'{0}' occurred {1} time/s",w.Key,w.Value))
                                .ToArray()));
    }
}