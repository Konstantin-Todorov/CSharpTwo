//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.
using System;
class LeapYear
{
    static void Main()
    {
        Console.Write("Enter Year /yyyy/ : ");
        int year = int.Parse(Console.ReadLine());
        if (DateTime.IsLeapYear(year) == true )
        {
            Console.WriteLine("The year {0} is leap .",year);
        }
        else
        {
            Console.WriteLine("The year {0} is not leap",year);
        }
    }
}
