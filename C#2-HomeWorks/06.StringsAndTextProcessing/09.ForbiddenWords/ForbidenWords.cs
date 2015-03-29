//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.
//Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

//Forbidden words: PHP, CLR, Microsoft

//The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
using System;
using System.Text.RegularExpressions;
class ForbidenWords
{
    static void Main()
    {
        Console.Write("Enter a text : ");
        string text = Console.ReadLine();
        string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };
        string newText  = string.Format(@"\b({0})\b", string.Join("|",forbiddenWords));
        Console.WriteLine("\nResult : {0}",Regex.Replace(text,newText,words =>new string('*',words.Length)));    
    }
}
