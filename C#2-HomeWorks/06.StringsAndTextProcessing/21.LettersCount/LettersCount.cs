//Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.
using System;
using System.Linq;
using System.Text.RegularExpressions;
class LettersCount
{
    static void Main()
    {
        Console.Write("Enter a text : ");
        string text = Console.ReadLine().ToLower();
        var chars = text.ToArray().GroupBy(c => c);
        foreach (var ch in chars)
        {
            Console.WriteLine("'{0}' is found {1} time/s",ch.Key,ch.Count());
        }
    }
}
