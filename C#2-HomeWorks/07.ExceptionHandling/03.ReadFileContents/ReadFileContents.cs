//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.
using System;
using System.IO;
using System.Security;
class ReadFileContents
{
    static void Main()
    {
        try
        {
            Console.Write("Enter File`s full path : ");
            string pathFile = Console.ReadLine();
            string text = ReadFile(pathFile);
            Console.WriteLine("Files Content : {0}", text);
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("File`s pats containts a directory that cannot be found ! ");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found or does not exist ! ");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("No path is given ! ");
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("The path is incorect");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The entered path is too long (Enter 248 characters Maximum) !");
        }
        catch (SecurityException)
        {
            Console.WriteLine("You dont have a premission to enter this file ! ");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Invalid path format ! ");
        }
        catch (IOException ioEx)
        {
            Console.WriteLine(ioEx.Message);
        }
        catch (UnauthorizedAccessException unauthorizedEx)
        {
            Console.WriteLine(unauthorizedEx.Message);
        }
    }
    static string ReadFile(string filePath)
    {
        string file = File.ReadAllText(filePath);
        return file;
    }
}