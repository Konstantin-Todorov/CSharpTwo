//Write a program to convert decimal numbers to their hexadecimal representation.
using System;
using System.Text;
class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter Decimal number : ");
        int decimalNumber = int.Parse(Console.ReadLine());
        StringBuilder hexadecimalNumber = new StringBuilder();
        while (decimalNumber > 0)
        {
            switch (decimalNumber % 16)
            {
                case 10: hexadecimalNumber.Append('A'); break;
                case 11: hexadecimalNumber.Append('B'); break;
                case 12: hexadecimalNumber.Append('C'); break;
                case 13: hexadecimalNumber.Append('D'); break;
                case 14: hexadecimalNumber.Append('E'); break;
                case 15: hexadecimalNumber.Append('F'); break;
                default: hexadecimalNumber.Append(decimalNumber % 16); break;
            }
            decimalNumber /= 16;
        }
        string finalHexacemialNum = hexadecimalNumber.ToString();
        Console.WriteLine("The number in Hexadecimal : ");
        for (int i = finalHexacemialNum.Length - 1; i >= 0; i--)
        {
            Console.Write(finalHexacemialNum[i]);
        }
        Console.WriteLine();
    }
}

