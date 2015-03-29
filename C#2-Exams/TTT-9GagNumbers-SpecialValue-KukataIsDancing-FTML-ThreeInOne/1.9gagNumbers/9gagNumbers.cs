using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static string ConvertNumber(string digit)
    {
        string result = "NO";
        switch (digit)
        {
            case "-!": result = "0"; break;
            case "**": result = "1"; break;
            case "!!!": result = "2"; break;
            case "&&": result = "3"; break;
            case "&-": result = "4"; break;
            case "!-": result = "5"; break;
            case "*!!!": result = "6"; break;
            case "&*!": result = "7"; break;
            case "!!**!-": result = "8"; break;
            default:
                break;
        }
        return result;
    }
    static void Main()
    {
        string input = Console.ReadLine();
        string partialInput = string.Empty;
        string nineNumeralSystem = "";
        for (int i = 0; i < input.Length; i++)
        {
            partialInput += input[i];
            string currentDigit = ConvertNumber(partialInput);
            if (currentDigit != "NO")
            {
                nineNumeralSystem += currentDigit;
                partialInput = "";
            }
        }
        ulong result = 0;
        for (int i = 0; i < nineNumeralSystem.Length; i++)
        {
            ulong digit = ulong.Parse(nineNumeralSystem[i].ToString());
            result += digit * Power(nineNumeralSystem.Length - i - 1);
        }
        Console.WriteLine(result);
    }

    private static ulong Power(int power)
    {
        ulong result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= 9;
        }
        return result;
    }
    //static string[] digits = { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };
    //static void Main()
    //{
    //    string number = Console.ReadLine();
    //    ulong result = 0;
    //    while (number.Length > 0)
    //    {
    //        for (int i = 0; i < digits.Length; i++)
    //        {
    //            if (number.StartsWith(digits[i]))
    //            {
    //                number = number.Remove(0, digits[i].Length);
    //                result = result * 9 + (ulong)i;
    //            }
    //        }
    //    }
    //    Console.WriteLine(result);
}