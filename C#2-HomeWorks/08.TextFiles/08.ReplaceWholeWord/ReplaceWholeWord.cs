//Modify the solution of the previous problem to replace only whole words (not strings).
using System;
using System.IO;
using System.Text.RegularExpressions;
class ReplaceWholeWord
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\Input.txt"))
        {
            using (StreamWriter output = new StreamWriter(@"..\..\Output.txt"))
            {
                {
                    while (!reader.EndOfStream)
                    {
                        output.WriteLine(Regex.Replace(reader.ReadLine(), @"\bstart\b", "finish"));
                    }
                }
            }
        }
    }
}