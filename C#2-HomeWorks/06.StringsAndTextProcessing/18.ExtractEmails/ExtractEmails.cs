//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
using System;
using System.Text.RegularExpressions;
class ExtractEmails
{
    static void Main()
    {
        Console.Write("Enter text : ");
        string text = Console.ReadLine();
        string[] email = text.Split(new[] { " ", ", ", ",", ". ", ";" }, StringSplitOptions.RemoveEmptyEntries);
        string[] validMails = Array.FindAll(email, ValidMailsSearch);
        PrintEmails(validMails);
    }

    static bool ValidMailsSearch(string email)
    {
        string patterns =   @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        return new Regex(patterns).IsMatch(email);
    }

    static void PrintEmails(string[] validMails)
    {
        foreach (var email in validMails)
        {
            Console.WriteLine("The e-mail is : {0}", email);
        }
    }
}
