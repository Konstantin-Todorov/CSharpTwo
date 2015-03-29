//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//Example:

// input	                    output
//aaaaabbbbbcdddeeeedssaa	   abcdedsa
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class SeriesOfLetters
{
    static void Main()
    {
        Console.Write("Enter a text : ");
        string text = Console.ReadLine();
        string result = new String(text.Distinct().ToString());
        Console.WriteLine("Unique characters : {0}", result);
    }
}
