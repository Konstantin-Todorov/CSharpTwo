//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:

//The target sub-string is in

//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The result is: 9
using System;
using System.Linq;
class SubStringInText
{
    static void Main()
    {
        Console.Write("Enter a text :  ");
        string text = Console.ReadLine();
        Console.Write("Enter a substring you want to search :  ");
        string searchingSubstr = Console.ReadLine();
        int count = text.Select((c, i) => text.Substring(i)).Count(subStr => subStr.StartsWith(searchingSubstr));
        Console.WriteLine(count);
    }
}
