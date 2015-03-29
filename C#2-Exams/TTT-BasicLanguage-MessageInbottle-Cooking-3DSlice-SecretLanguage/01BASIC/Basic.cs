using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Basic
{
    private static StringBuilder output = new StringBuilder();
    static List<string> allCommands = new List<string>();
    internal static void Main()
    {
        ReadInput();
        ConvertInputToComannds();
        RunCommands();
        Console.Write(output.ToString());
    }

     private static void RunCommands()
    {
        output.Clear(); 
        for (int i = 0; i < allCommands.Count; i++)
        {
            int allLoops = 1;
            string[] subCommand = allCommands[i].Split(new char[] { ')' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var command in subCommand)
            {
                string currnetCommand = command.TrimStart(); 
                if (currnetCommand.StartsWith("EXIT"))
                {
                    return;
                }
                else if (currnetCommand.StartsWith("PRINT"))
                {
                    int paramsStart = currnetCommand.IndexOf("(") + 1;
                    string content = currnetCommand.Substring(paramsStart);
                    for (int j = 0; j < allLoops; j++)
                    {
                        output.Append(content);
                    }
                }
                else if (currnetCommand.StartsWith("FOR"))
                { 
                    int paramsStart = currnetCommand.IndexOf("(") + 1;
                    string allParams = currnetCommand.Substring(paramsStart);
                    if (allParams.Contains(","))
                    {
                        string[] loopParams = allParams.Split(',');
                        int a = int.Parse(loopParams[0]);
                        int b = int.Parse(loopParams[1]);
                        allLoops = allLoops * (b - a + 1);
                    }
                    else 
                    {
                        var value = int.Parse(allParams);
                        allLoops = allLoops * value;
                    }
                }
            }
        }
    }

     private static void ConvertInputToComannds()
    {
        string allInput = output.ToString();
        output.Clear();
        foreach (var symbol in allInput)
        {
            if (symbol == ';')
            {
                allCommands.Add(output.ToString());
                output.Clear();
            }
        }
    }

     private static void ReadInput()
    {
        while (true)
        {
            var line = Console.ReadLine();
            output.Append(line);
            if (line == "EXIT;")
            {
                break;
            }
        }
    }
}