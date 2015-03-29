//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
class RemoveWords
{
    static void Main()
    {
        try
        {
            string allLines = String.Join(" ", File.ReadAllLines(@"..\..\RemoveWords.txt"));
            string[] allWords = allLines.Split(' ');
            using (StreamReader start = new StreamReader(@"..\..\InputText.txt"))
            {
                string line = start.ReadLine();
                using (StreamWriter finish = new StreamWriter(@"..\..\FinalText.txt"))
                {
                    while (line != null)
                    {
                        for (int i = 0; i < allWords.Length; i++)
                        {
                            string word = "\\b" + allWords[i] + "\\b";
                            line = Regex.Replace(line, word, "");
                        }
                        finish.WriteLine(line);
                        line = start.ReadLine();
                    }
                }
            }
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileLoadException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (EndOfStreamException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}