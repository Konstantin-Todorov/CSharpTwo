//Write a program to convert binary numbers to their decimal representation.
using System;
class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter number in Binary : ");
        string binaryNumber = Console.ReadLine();
        long decimalNumber = 0;
        long multiplier = 1;
        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            if (binaryNumber[i] == '1')
            {
                decimalNumber += multiplier;
            }
            multiplier *= 2; 
        }
        Console.WriteLine("The number in Decimal : {0}",decimalNumber);
    }
}

