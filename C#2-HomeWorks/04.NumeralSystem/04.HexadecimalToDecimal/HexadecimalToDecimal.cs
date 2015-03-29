//Write a program to convert hexadecimal numbers to their decimal representation.
using System;
using System.Collections.Generic;
class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter Hexadecimal number : ");
        string strangeNumber = Console.ReadLine();
        strangeNumber = strangeNumber;
        int[] convertedNumber = new int[strangeNumber.Length];
        for (int i = 0; i < strangeNumber.Length; i++)
        {
            switch (strangeNumber[i])
            {
                case 'a': convertedNumber[i] = 0; break;
                case 'b': convertedNumber[i] = 1; break;
                case 'c': convertedNumber[i] = 2; break;
                case 'd': convertedNumber[i] = 3; break;
                case 'e': convertedNumber[i] = 4; break;
                case 'f': convertedNumber[i] = 5; break;
                case 'g': convertedNumber[i] = 6; break;
                case 'h': convertedNumber[i] = 7; break;
                case 'i': convertedNumber[i] = 8; break;
                case 'j': convertedNumber[i] = 9; break;
                case 'k': convertedNumber[i] = 10; break;
                case 'l': convertedNumber[i] = 11; break;
                case 'm': convertedNumber[i] = 12; break;
                case 'n': convertedNumber[i] = 13; break;
                case 'o': convertedNumber[i] = 14; break;
                case 'p': convertedNumber[i] = 15; break;
                case 'q': convertedNumber[i] = 16; break;
                case 'r': convertedNumber[i] = 17; break;
                case 's': convertedNumber[i] = 18; break;
                case 't': convertedNumber[i] = 19; break;
                case 'u': convertedNumber[i] = 20; break;
                default: convertedNumber[i] = int.Parse(Convert.ToString(strangeNumber[i])); break;
            }
        }
        int twntyOneNumber = 0;
        int power = strangeNumber.Length - 1;
        for (int i = 0; i < convertedNumber.Length; i++)
        {
            twntyOneNumber += convertedNumber[i] * (int)Math.Pow(21, power);
            power--;
        }
        Console.WriteLine(twntyOneNumber);
    }
}
