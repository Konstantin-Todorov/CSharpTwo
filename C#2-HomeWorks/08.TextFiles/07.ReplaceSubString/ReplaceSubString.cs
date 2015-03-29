//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).
using System;
using System.IO;
class ReplaceSubString
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\Input.txt"))
        {
            using (StreamWriter output = new StreamWriter(@"..\..\Output.txt"))
            {
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    string newLine = line.Replace("finish", "start");
                    output.WriteLine(newLine);
                }
            }
        }
    }
}