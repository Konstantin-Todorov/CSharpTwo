using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ConsoleJustification
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());
        int limitWords = int.Parse(Console.ReadLine());
        string text = string.Empty;
        for (int i = 0; i < lines; i++)
        {
            text += " " + Console.ReadLine();
        }
        PrintLines(text, limitWords);
    }

    static void PrintLines(string text, int limitWords)
    {
        StringBuilder line = new StringBuilder();
        string[] topic = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < topic.Length; i++)
        {
            if (line.Length + topic[i].Length > limitWords)
            {
                Console.WriteLine(AddSpaces(line,limitWords));
                line.Clear();
            }
            line.Append(topic[i] + " ");
        }
        Console.WriteLine(AddSpaces(line,limitWords));
    }

    static StringBuilder AddSpaces(StringBuilder line, int limitWords)
    {
        line.Remove(line.Length - 1, 1);
        int spaceIndex = line.ToString().IndexOf(" ");
        int mostSpaces = 2;
        while (limitWords - line.Length > 0 && spaceIndex != -1)
        {
            line.Insert(spaceIndex, ' ');
            spaceIndex = line.ToString().IndexOf(new string(' ', mostSpaces - 1), spaceIndex + 2);
            if (spaceIndex == -1)
            {
                spaceIndex = line.ToString().IndexOf(new string(' ', mostSpaces++), 0);
            }
        }
        return line;
    }
}