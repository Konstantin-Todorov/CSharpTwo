//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
//Sample dictionary:
//input	                        output
//.NET	         platform for applications from Microsoft
//CLR	         managed execution environment for .NET
//namespace	     hierarchical organization of classes
using System;
using System.Collections.Generic;
class WordDictionary
{
    static void Main()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            {".NET","platform for applications from Microsoft"},
            {"CLR","managed execution enviroment for .NET"},
            {"NAMESPACE","hierarchical organization of classes"}
        };
        Console.WriteLine("Dictionary Words = {0}",string.Join(" ,",dict.Keys));
        Console.Write("Enter word : ");
        string word = Console.ReadLine().ToUpper();
        if (dict.ContainsKey(word))
        {
            Console.WriteLine(dict[word]);
        }
        else
        {
            Console.WriteLine("This word is not in the dictionary !");
        }
    }
}