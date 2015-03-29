﻿//Write a program that extracts from given XML file all the text without the tags.
//Example:

//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>
using System;
using System.Collections.Generic;
using System.IO;
class ExtractTextFromXML
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\XMLText.txt"))
        {
            string line = reader.ReadLine();
            string extract = string.Empty;
            while (line != null)
            {
                for (int i = 1; i < line.Length; i++)
                {
                    if (line[i - 1] == '>')
                    {
                        while (line[i] != '<')
                        {
                            extract += line[i];
                            i++;
                        }
                        if (extract != "")
                        {
                            Console.WriteLine(extract.TrimStart(' '));
                            extract = "";
                        }
                    }
                }
                line = reader.ReadLine();
            }
        }
    }
}
