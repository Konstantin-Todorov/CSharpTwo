//Write a method that returns the last digit of given integer as an English word.
//Examples:

//input	output
//512	two
//1024	four
//12309	nine
using System;
class EnglishDigit
{
    static void Main()
    {
        Console.Write("Enter a number : ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("The last digit of the number is ",number);
        LastDigitInEnglish(number);
    }

    static string LastDigitInEnglish(int number)
    {
        int digit = number % 10;
        switch (digit)
        {
            case 0: Console.WriteLine("Zero"); break;
            case 1: Console.WriteLine("One"); break;
            case 2: Console.WriteLine("Two"); break;
            case 3: Console.WriteLine("Three"); break;
            case 4: Console.WriteLine("Four"); break;
            case 5: Console.WriteLine("Five"); break;
            case 6: Console.WriteLine("Six"); break;
            case 7: Console.WriteLine("Seven"); break;
            case 8: Console.WriteLine("Eight"); break;
            case 9: Console.WriteLine("Nine"); break;
        }
        return String.Empty;
    }
}
