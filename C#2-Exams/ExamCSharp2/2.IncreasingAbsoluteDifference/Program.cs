using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static string[] digits = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u" };
    static void Main()
    {


        string[] number = Console.ReadLine().Split();

        long result = 0;
        StringBuilder newResult = new StringBuilder();
        long twntyOneNumber = 0;
        long power = number.Length - 1;
        for (long i = 0; i < digits.Length; i++)
        {
            twntyOneNumber += long.Parse(Convert.ToString(number[i])) * Power(21, power);
            power--;
        }
        for (long i = 0; i < digits.Length; i++)
        {

            result = twntyOneNumber % 26;
            twntyOneNumber = twntyOneNumber / 26;
            char final = Convert.ToChar(result + 97);
            newResult = newResult.Append(final);

        }
        Reverse(newResult);
        Console.WriteLine(newResult);

    }
    static long Power(long number, long power)
    {
        long result = 1;
        for (long i = 0; i < power; i++)
        {
            result *= number;
        }
        return result;
    }
    public static void Reverse(StringBuilder text)
    {
        if (text.Length > 1)
        {
            int pivotPos = text.Length / 2;
            for (int i = 0; i < pivotPos; i++)
            {
                int iRight = text.Length - (i + 1);
                char rightChar = text[i];
                char leftChar = text[iRight];
                text[i] = leftChar;
                text[iRight] = rightChar;
            }
        }
    }
}