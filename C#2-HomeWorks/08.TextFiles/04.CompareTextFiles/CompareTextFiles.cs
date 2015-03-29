//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.
using System;
using System.IO;
using System.Collections.Generic;
class CompareTextFiles
{
    static void Main()
    {
        StreamReader readerOne = new StreamReader(@"..\..\FirstText.txt");
        StreamReader readerTwo = new StreamReader(@"..\..\SecondText.txt");

        using (readerOne)
        {
            using (readerTwo)
            {
                string linesTextOne = readerOne.ReadLine();
                string linesTextTwo = readerTwo.ReadLine();
                int count = 1;
                List<int> sameLines = new List<int>();
                List<int> differentLines = new List<int>();
                while (linesTextOne != null)
                {
                    if (linesTextOne.Equals(linesTextTwo))
                    {
                        sameLines.Add(count);
                    }
                    else
                    {
                        differentLines.Add(count);
                    }
                    count++;
                    linesTextOne = readerOne.ReadLine();
                    linesTextTwo = readerTwo.ReadLine();
                }
                Console.WriteLine("Same lines: {0}", string.Join(" ", sameLines));
                Console.WriteLine("Different lines: {0}", string.Join(" ", differentLines));
            }
        }
    }
}