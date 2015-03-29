using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//class Program
//{

//    static string ConvertNumber(string digit)
//    {
//        string result = "NO";
//        switch (digit)
//        {
//            case "a": result = "0"; break;
//            case "b": result = "1"; break;
//            case "c": result = "2"; break;
//            case "d": result = "3"; break;
//            case "e": result = "4"; break;
//            case "f": result = "5"; break;
//            case "g": result = "6"; break;
//            case "h": result = "7"; break;
//            case "i": result = "8"; break;
//            case "j": result = "9"; break;
//            case "k": result = "10"; break;
//            case "l": result = "11"; break;
//            case "m": result = "12"; break;
//            case "n": result = "13"; break;
//            case "o": result = "14"; break;
//            case "p": result = "15"; break;
//            case "q": result = "16"; break;
//            case "r": result = "17"; break;
//            case "s": result = "18"; break;
//            case "t": result = "19"; break;
//            case "u": result = "20"; break;
//            default:
//                break;
//        }
//        return result;
//    }
//    static void Main()
//    {
//        string input = Console.ReadLine();
//        string partialInput = string.Empty;
//        string nineNumeralSystem = "";
//        for (int i = 0; i < input.Length; i++)
//        {
//            partialInput += input[i];
//            string currentDigit = ConvertNumber(partialInput);
//            if (currentDigit != "NO")
//            {
//                nineNumeralSystem += currentDigit;
//                partialInput = "";
//            }
//        }
//        ulong result = 0;
//        for (int i = 0; i < nineNumeralSystem.Length; i++)
//        {
//            ulong digit = ulong.Parse(nineNumeralSystem[i].ToString());
//            result += digit * Power(nineNumeralSystem.Length - i - 1);
//        }
//        Console.WriteLine(result);
//    }

//    private static ulong Power(int power)
//    {
//        ulong result = 1;
//        for (int i = 0; i < power; i++)
//        {
//            result *= 9;
//        }
//        return result;
//    }
//}
class Program
{
    static void Main()
    {
        string strangeNumber = Console.ReadLine()
          .Replace("a", "0")
          .Replace("b", "1")
          .Replace("c", "2")
          .Replace("d", "3")
          .Replace("e", "4")
          .Replace("f", "5")
          .Replace("g", "6")
          .Replace("h", "7")
          .Replace("i", "8")
          .Replace("j", "9")
          .Replace("k", "10")
          .Replace("l", "11")
          .Replace("m", "12")
          .Replace("n", "13")
          .Replace("o", "14")
          .Replace("p", "15")
          .Replace("q", "16")
          .Replace("r", "17")
          .Replace("s", "18")
          .Replace("t", "19")
          .Replace("u", "20");
        int power = 0;
        BigInteger result = 0;


        for (int i = strangeNumber.Length - 1; i >= 0; i--)
        //{
        //    if (strangeNumber[i] == 'a' || strangeNumber[i] == 'b' || strangeNumber[i] == 'c' || strangeNumber[i] == 'd' || strangeNumber[i] == 'e' || strangeNumber[i] == 'f' ||
        //        strangeNumber[i] == 'g' || strangeNumber[i] == 'h' || strangeNumber[i] == 'i' || strangeNumber[i] == 'j'
        //            || strangeNumber[i] == 'k' || strangeNumber[i] == 'l' || strangeNumber[i] == 'm')
        //        {
        //            int strangeNumber = strangeNumber[i] - 97 - 1;
        //            result += transferLittleAlpha;
        //        }
        
            int currentNumber =  strangeNumber.Substring(strangeNumber[i],strangeNumber[i+1]) ;
            result += currentNumber * Power(21, power);
            power++;
        }
        Console.WriteLine(result);
    }
    static int Power(int number, int power)
    {
        BigInteger result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= number;
        }
        return result;
    }
}