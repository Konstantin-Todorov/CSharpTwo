//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
//Example input:

//<html><head><title>News</title></head><body><p><a href="http://academy.telerik.com">TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn intoskilful .NET software engineers.</p></body></html>
//  
//  
//    
//    
//    
//
//Output:

//Title: News

//Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.
using System;
using System.Text.RegularExpressions;
class ExtrTextFromHTML
{
    static void Main()
    {
        Console.WriteLine("Enter input : ");
        string htmlText = Console.ReadLine();
        foreach (var text in Regex.Matches(htmlText, "(?<=^|>)[^><]+?(?=<|$)"))
        {
            Console.WriteLine("Output : {0}" ,text);
        }
    }
}