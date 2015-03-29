//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.
using System;
using System.Globalization;
using System.Threading;
using System.Text.RegularExpressions;
class DatesFromTextInCanada
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
        Console.Write("Enter text : ");
        //string text = "02.10.2015 03.5.2015 2.1.2015 2.10.2015";
        string text = Console.ReadLine();
        string format = "d.M.yyyy";
        CultureInfo provider = Thread.CurrentThread.CurrentCulture;

        foreach (var match in Regex.Matches(text, @"[\d]{1,2}.[\d]{1,2}.[\d]{4}"))
        {
            DateTime check = DateTime.ParseExact(match.ToString(), format, provider);
            Console.WriteLine("The dates are : {0}", check.ToShortDateString());
        }
    }
}
