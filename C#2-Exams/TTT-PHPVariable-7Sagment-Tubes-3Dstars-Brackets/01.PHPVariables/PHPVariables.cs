using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum ParserState
{
    Normal,
    SingleComment,
    MultyComment,
    SingleQuote,
    DoubleQuote
}
class PHPVariables
{
    static ParserState state = ParserState.Normal;
    static bool addChars = false;
    static List<string> variables = new List<string>();
    static StringBuilder varBuilder = new StringBuilder();

    static void Main()
    {
        string line = Console.ReadLine();
        while (line != "?>")
        {
            ParseLine(line);
            line = Console.ReadLine();
        }
        Console.WriteLine(variables.Count);
        variables.Sort(StringComparer.Ordinal);
        foreach (string str in variables)
        {
            Console.WriteLine(str);
        }
    }

    private static void ParseLine(string line)
    {
        for (int i = 0; i < line.Length; i++)
        {
            char currentChar = line[i];
            if (currentChar == '$')
            {
                if (addChars)
                {
                    AddVariable();
                }
                switch (state)
                {
                    case ParserState.Normal: addChars = true; break;
                    case ParserState.SingleComment: break;
                    case ParserState.MultyComment: break;
                    case ParserState.SingleQuote:
                        if ((i > 0 && line[i - 1] != '\\') || (i > 1 && line[i - 1] == '\\' && line[i - 2] == '\\'))
                        {
                            addChars = true;
                        }
                        break;
                    case ParserState.DoubleQuote:
                        if ((i > 0 && line[i - 1] != '\\') || (i > 1 && line[i - 1] == '\\' && line[i - 2] == '\\'))
                        {
                            addChars = true;
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (currentChar == '#')
            {
                if (addChars)
                {
                    AddVariable();
                }
                switch (state)
                {
                    case ParserState.Normal: state = ParserState.SingleComment; break;
                    case ParserState.SingleComment: break;
                    case ParserState.MultyComment: break;
                    case ParserState.SingleQuote: break;
                    case ParserState.DoubleQuote: break;
                    default:
                        break;
                }
            }
            else if (currentChar == '\'')
            {
                if (addChars)
                {
                    AddVariable();
                }
                switch (state)
                {
                    case ParserState.Normal: state = ParserState.SingleQuote; break;
                    case ParserState.SingleComment:break;
                    case ParserState.MultyComment:break;
                    case ParserState.SingleQuote:
                        if ((i > 0 && line[i - 1] != '\\') || (i > 1 && line[i - 1] == '\\' && line[i - 2] == '\\'))
                        {
                            state = ParserState.Normal;
                        }
                        break;
                    case ParserState.DoubleQuote:break;
                    default:
                        break;
                }
            }
            else if (currentChar == '"')
            {
                if (addChars)
                {
                    AddVariable();
                }
                switch (state)
                {
                    case ParserState.Normal: state = ParserState.DoubleQuote; break;
                    case ParserState.SingleComment:break;
                    case ParserState.MultyComment:break;
                    case ParserState.SingleQuote:break;
                    case ParserState.DoubleQuote:
                        if ((i > 0 && line[i - 1] != '\\') || (i > 1 && line[i - 1] == '\\' && line[i - 2] == '\\'))
                        {
                            state = ParserState.Normal;
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (currentChar == '/')
            {
                if (addChars)
                {
                    AddVariable();
                }
                switch (state)
                {
                    case ParserState.Normal:
                        if (i < line.Length - 1 && line[i + 1] == '/') 
                        {
                            state = ParserState.SingleComment;
                        }
                        else if (i<line.Length - 1 && line[i+1] == '*')
                        {
                            state = ParserState.MultyComment;
                        }
                        break;
                    case ParserState.SingleComment: break;
                    case ParserState.MultyComment: 
                        if (i>0 && line[i -1] == '*')
                        {
                            state = ParserState.Normal;
                        }
                        break;
                    case ParserState.SingleQuote: break;
                    case ParserState.DoubleQuote: break;
                    default:
                        break;
                }
            }
            else
            {
                if (addChars)
                {
                    if (char.IsDigit(currentChar) || char.IsLetter(currentChar) || currentChar == '_')
                    {
                        varBuilder.Append(currentChar);
                    }
                    else
                    {
                        AddVariable();
                    }
                }
            }
        }
        if (state == ParserState.SingleComment)
        {
            state = ParserState.Normal;
        }
        if (addChars)
        {
            AddVariable();
        }
    }

    private static void AddVariable()
    {
        string currentVariable = varBuilder.ToString();
        if (currentVariable != "")
        {
            if (!variables.Contains(currentVariable))
            {
                variables.Add(currentVariable);
            }
        }
        varBuilder.Clear();
        addChars = false;
    }
}
