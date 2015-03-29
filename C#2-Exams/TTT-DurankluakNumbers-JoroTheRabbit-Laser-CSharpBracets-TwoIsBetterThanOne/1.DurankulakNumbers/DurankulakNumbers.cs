using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class DurankulakNumbers
{
    static void Main()
    {
        string[] duranKulakDigits = GetDuranKulakDigits();
        string durankulakNumbers = Console.ReadLine();
        List<uint> decimalRepresentation = GetDecimalRepresentation(duranKulakDigits, durankulakNumbers);
        ulong decimalNumber = GetDecimalNumber(decimalRepresentation);
        Console.WriteLine(decimalNumber);

        //string inputNumber = Console.ReadLine());
        //List<string> digits = new List<string>();

        //for (char i = 'A'; i <= 'Z'; i++)
        //{
        //    digits.Add(i.ToString());
        //}
        //for (char i = 'a'; i <= 'z'; i++)
        //{
        //    for (char j = 'A'; j <= 'Z'; j++)
        //    {
        //        digits.Add(i.ToString() + j.ToString());
        //    }
        //}
        //string result = string.Empty;
        //if (inputNumber == 0)
        //{
        //    Console.WriteLine('A');
        //}
        //while (inputNumber != 0)
        //{
        //    result = digits[inputNumber % 168] + result;
        //    inputNumber = inputNumber / 168;
        //}
        //Console.WriteLine(result);
    }
    static ulong GetDecimalNumber(List<uint> decimalRepresentations)
    {
        ulong result = 0;
        for (int i = 0; i < decimalRepresentations.Count; i++)
        {
            result += decimalRepresentations[decimalRepresentations.Count - i -1] * (ulong)Math.Pow(168, i);
        }
        return result;

    }

    private static List<uint> GetDecimalRepresentation(string[] duranKulakDigits, string durankulakNumbers)
    {
        List<uint> decimalRepresentations = new List<uint>();
        char buffer = new char();
        foreach (var symbol in durankulakNumbers)
        {
            if (symbol >= 'A' && symbol <= 'Z')
            {
                string durankulakDigit = null;
                uint decimalRepresentation = 0;
                if (buffer != default(char))
                {
                    durankulakDigit = buffer + symbol.ToString();
                    decimalRepresentation = (uint)Array.IndexOf(duranKulakDigits, durankulakDigit);
                    buffer = default(char);
                }
                else
                {
                    durankulakDigit = symbol.ToString();
                }
                decimalRepresentation = (uint)Array.IndexOf(duranKulakDigits, durankulakDigit);
                decimalRepresentations.Add(decimalRepresentation);
            }
            else
            {
                buffer = symbol;
            }
        }


        return decimalRepresentations;
    }

    private static string[] GetDuranKulakDigits()
    {
        string[] durankulakNumbers = new string[168];
        for (int i = 0; i < 168; i++)
        {
            if (i < 26)
            {
                durankulakNumbers[i] = ((char)('A' + i)).ToString();
            }
            else if (i < 2 * 26)
            {
                durankulakNumbers[i] = "a" + durankulakNumbers[i - 26];
            }
            else if (i < 3 * 26)
            {
                durankulakNumbers[i] = "b" + durankulakNumbers[i - 2 * 26];
            }
            else if (i < 4 * 26)
            {
                durankulakNumbers[i] = "c" + durankulakNumbers[i - 3 * 26];
            }
            else if (i < 5 * 26)
            {
                durankulakNumbers[i] = "d" + durankulakNumbers[i - 4 * 26];
            }
            else if (i < 6 * 26)
            {
                durankulakNumbers[i] = "e" + durankulakNumbers[i - 5 * 26];
            }
            else
            {
                durankulakNumbers[i] = "f" + durankulakNumbers[i - 6 * 26];
            }

        }
        return durankulakNumbers;


    }

}