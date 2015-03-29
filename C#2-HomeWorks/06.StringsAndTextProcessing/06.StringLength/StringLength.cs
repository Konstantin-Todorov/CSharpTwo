//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.
using System;
class StringLenght
{
    static void Main()
    {
        Console.WriteLine("Enter a text with maximum 20 characters : ");
        string text = Console.ReadLine();
        if (text.Length <= 20)
        {
            text = text.PadRight(20, '*');
            Console.WriteLine("Filled text : \n{0}", text);
        }
        else
        {
            Console.WriteLine("Enter 20 characters ! ");
        }
    }
}
