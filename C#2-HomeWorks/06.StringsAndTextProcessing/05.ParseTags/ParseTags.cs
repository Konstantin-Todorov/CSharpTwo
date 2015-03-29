//Youu are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
using System;
using System.Text.RegularExpressions;
class ParseTags
{
    static void Main()
    {
        Console.Write("Enter Text : ");
        string text = Console.ReadLine();
        Console.WriteLine("\nThe transformed text : ");
        Console.WriteLine(Regex.Replace(text,"<upcase>(.*?)</upcase>", words =>words.Groups[1].Value.ToUpper()));
    }
}
