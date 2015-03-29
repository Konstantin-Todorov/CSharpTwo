//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.
using System;
using System.IO;
class LineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\Without.txt");

        using (reader)
        {
            string line = reader.ReadLine();
            StreamWriter writer = new StreamWriter(@"..\..\With.txt");
            int lineNum = 0;
            using (writer)
            {
                while (line != null)
                {
                    lineNum++;
                    writer.WriteLine("Line {0}: {1}", lineNum, line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}
