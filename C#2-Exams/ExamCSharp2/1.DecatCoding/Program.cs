using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class TwentyoneNum
{
    static void Main()
    {

        string[] strangeNumber = Console.ReadLine();
        //string[] input = strangeNumber.Split(' ');

        long[] convertedNumber = new long[strangeNumber.Length];
        for (int i = 0; i < convertedNumber.Length; i++)
        {
            switch (strangeNumber[i])
            {
                case "a": convertedNumber[i] = 0; break;
                case "b": convertedNumber[i] = 1; break;
                case "c": convertedNumber[i] = 2; break;
                case "d": convertedNumber[i] = 3; break;
                case "e": convertedNumber[i] = 4; break;
                case "f": convertedNumber[i] = 5; break;
                case "g": convertedNumber[i] = 6; break;
                case "h": convertedNumber[i] = 7; break;
                case "i": convertedNumber[i] = 8; break;
                case "j": convertedNumber[i] = 9; break;
                case "k": convertedNumber[i] = 10; break;
                case "l": convertedNumber[i] = 11; break;
                case "m": convertedNumber[i] = 12; break;
                case "n": convertedNumber[i] = 13; break;
                case "o": convertedNumber[i] = 14; break;
                case "p": convertedNumber[i] = 15; break;
                case "q": convertedNumber[i] = 16; break;
                case "r": convertedNumber[i] = 17; break;
                case "s": convertedNumber[i] = 18; break;
                case "t": convertedNumber[i] = 19; break;
                case "u": convertedNumber[i] = 20; break;
            }
        }

        long result = 0;
        StringBuilder newResult = new StringBuilder();
        long twntyOneNumber = 0;
        int power = convertedNumber.Length - 1;
        for (int i = 0; i < convertedNumber.Length; i++)
        {
            twntyOneNumber += convertedNumber[i] * Power(21, power);
            power--;
           
        }
        for (int j = 0; j < strangeNumber.Length; j++)
        {

            result = twntyOneNumber % 26;
            twntyOneNumber = twntyOneNumber / 26;
            char final = Convert.ToChar(result + 97);
            newResult = newResult.Append(final);
        }

        Reverse(newResult);
        Console.WriteLine(newResult);

    }
    static int Power(int number, int power)
    {
        int result = 1;
        for (int i = 0; i < power; i++)
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