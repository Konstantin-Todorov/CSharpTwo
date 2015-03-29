//Write a program to convert decimal numbers to their binary representation.
using System;
class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter Decimal number : ");
        int decimalNumber = int.Parse(Console.ReadLine());
        string result = ConvertToBinaty(decimalNumber);
        Console.WriteLine("The number in Binary : {0}",result);
    }

    static string ConvertToBinaty(int decimalNumber)
    {
        int reminder = 0;
        string result = string.Empty;
        while (decimalNumber > 0)
        {
            reminder = decimalNumber % 2;
            decimalNumber /= 2;
            result = reminder.ToString() + result;
        }
        return result;
    }
}

