//Write a program that reads a text file and prints on the console its odd lines.
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
class OddLines
{
    static void Main()
    {
        using (StringReader reader = new StringReader(@"..\..\OddLines.txt"))
        {
            int lineCount = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineCount % 2 == 1)
                {
                    Console.WriteLine(line);
                }
                lineCount++;
                line = reader.ReadLine();
            }
        }
    }
}
