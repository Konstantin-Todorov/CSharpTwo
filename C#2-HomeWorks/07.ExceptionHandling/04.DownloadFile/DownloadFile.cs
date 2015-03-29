//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.
using System;
using System.Net;
class DownloadFile
{
    static void Main()
    {
        using (WebClient downloadClient = new WebClient())
        {
            try
            {
                //Console.Write("Enter file address: ");
                // string fileAddress = Console.ReadLine();
                // Console.Write("Enter the item to download with extension (example news-img01.png) :");
                // string item = Console.ReadLine();
                // downloadClient.DownloadFile(fileAddress, item);
                downloadClient.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "news-img01.png");
                Console.WriteLine("The image was downloaded in 'bin' directory in the project ! ");
            }
            catch (ArgumentNullException nullEx)
            {
                Console.WriteLine(nullEx.Message);
            }
            catch (ArgumentException argumentEx)
            {
                Console.WriteLine(argumentEx.Message);
            }
            catch (WebException webEx)
            {
                Console.WriteLine(webEx.Message);
            }
            catch (NotSupportedException notSuppEx)
            {
                Console.WriteLine(notSuppEx.Message);
            }
        }
    }
}
