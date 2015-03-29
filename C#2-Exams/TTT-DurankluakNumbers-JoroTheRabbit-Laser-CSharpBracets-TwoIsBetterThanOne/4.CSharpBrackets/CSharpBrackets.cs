using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class CSharpBrackets
{
    static StringBuilder sb = new StringBuilder();
    static string tabs;
    static int tabsCount = 0;
    static bool shouldPrintNewLine = false;
    static bool isFirstSymbol = true;
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        tabs = Console.ReadLine();
        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine().Trim();
            HandleLine(line);
        }
        Console.WriteLine(sb);
    }

    private static void HandleLine(string line)
    {
        for (int i = 0; i < line.Length; i++)
        {
            char currentCharacter = line[i];
            if (shouldPrintNewLine && char.IsWhiteSpace(currentCharacter))
            {
                continue;
            }
            if (shouldPrintNewLine)
            {
                sb.AppendLine();
                shouldPrintNewLine = false;
                isFirstSymbol = true;
            }

            if (currentCharacter == '{')
            {
                if (!shouldPrintNewLine)
                {
                    if (!isFirstSymbol)
                    {
                        if (sb.Length > 0 && char.IsWhiteSpace(sb[sb.Length - 1]))
                        {
                            sb.Remove(sb.Length - 1, 1);
                        }
                        sb.AppendLine();
                    }
                }
                AppendTabs();
                sb.Append(currentCharacter);
                tabsCount++;
                shouldPrintNewLine = true;
            }
            else if (currentCharacter == '}')
            {
                tabsCount--;
                if (!shouldPrintNewLine)
                {
                    if (!isFirstSymbol)
                    {
                        if (sb.Length > 0 && char.IsWhiteSpace(sb[sb.Length - 1]))
                        {
                            sb.Remove(sb.Length - 1, 1);
                        }
                        sb.AppendLine();
                    }
                }
                AppendTabs();
                sb.Append(currentCharacter);
                shouldPrintNewLine = true;
            }
            else
            {
                if (isFirstSymbol)
                {
                    AppendTabs();
                }
                if (!(isFirstSymbol && char.IsWhiteSpace(currentCharacter)))
                {
                    if (!(i < line.Length - 1 && char.IsWhiteSpace(line[i]) && char.IsWhiteSpace(line[i + 1])))
                    {
                        sb.Append(currentCharacter);
                    }
                     
                }

                isFirstSymbol = false;
            }
        }
        shouldPrintNewLine = true;
        isFirstSymbol = true;
    }
    static void AppendTabs()
    {
        for (int i = 0; i < tabsCount; i++)
        {
            sb.Append(tabs);
        }
    }
}