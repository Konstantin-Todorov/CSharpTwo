//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:

//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days
using System;
class DateDifference
{
    static void Main()
    {
        Console.Write("Enter the first day 'day.month.year' : ");
        DateTime fisrstDay = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter the second day 'day.month.year' : ");
        DateTime secondDay = DateTime.Parse(Console.ReadLine());
        TimeSpan difference = fisrstDay - secondDay;
        Console.WriteLine("Distance : {0} days",Math.Abs(difference.Days));
    }
}
