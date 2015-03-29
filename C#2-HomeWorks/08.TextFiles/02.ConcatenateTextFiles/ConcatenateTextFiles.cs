//Write a program that concatenates two text files into another text file.
using System;
using System.IO;
class ConcatenateTextFiles
{
    static void Main()
    {
        using (StreamWriter write = new StreamWriter(@"..\..\ConcatenateTextFiles.txt", true))
        {
            using (StreamReader firstStReader = new StreamReader(@"..\..\FirstText.txt"))
            {
                string line = firstStReader.ReadLine();
                while (line != null)
                {
                    write.WriteLine(line);
                    line = firstStReader.ReadLine();
                }
            }
            using (StreamReader seconStReader = new StreamReader(@"..\..\SecondText.txt"))
            {
                string line = seconStReader.ReadLine();
                while (line != null)
                {
                    write.WriteLine(line);
                    line = seconStReader.ReadLine();
                }
            }
        }
        Console.WriteLine();
    }
}
