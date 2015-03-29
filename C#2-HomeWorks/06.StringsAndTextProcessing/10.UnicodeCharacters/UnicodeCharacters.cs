//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
//Example:

//input	   output
// Hi!	  \u0048\u0069\u0021
using System;
using System.Text;
class UnicodeCharacters
{
    static void Main()
    {
        Console.WriteLine("Enter text : ");
        string text = Console.ReadLine();
        StringBuilder uniCode = new StringBuilder();
        foreach (var chars in text)
        {
            uniCode.AppendFormat("\\u{0:X4}",(int)chars);
        }
        Console.WriteLine(uniCode.ToString());
    }
}
