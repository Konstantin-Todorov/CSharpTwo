//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
//Example:

//input.txt	   output.txt
//Ivan          George
//Peter         Ivan
//Maria         Maria
//George	    Peter
using System;
using System.IO;
using System.Collections.Generic;
class SaveSortedNames
{
    static void Main()
    {
        using (StreamReader input = new StreamReader(@"..\..\Input.txt"))
        {
            List<string> names = new List<string>();
            for (string currName = input.ReadLine(); currName != null; currName = input.ReadLine())
            {
                names.Add(currName);
            }
            names.Sort();
            using (StreamWriter output = new StreamWriter(@"..\..\Output.txt"))
            {
                foreach (string name in names)
                {
                    output.WriteLine(name);
                }
            }
        }
    }
}
