//Write a program to convert hexadecimal numbers to binary numbers (directly).
using System;
using System.Text;
class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter Hexadecmial number : ");
        string hexadecimalNumber = Console.ReadLine();
        hexadecimalNumber = hexadecimalNumber.ToUpper();
        StringBuilder binaryNumber = new StringBuilder();
        for (int i = 0; i < hexadecimalNumber.Length; i++)
        {
            switch (hexadecimalNumber[i])
            {
                case '0': binaryNumber.Append("0000"); break;
                case '1': binaryNumber.Append("0001"); break;
                case '2': binaryNumber.Append("0010"); break;
                case '3': binaryNumber.Append("0011"); break;
                case '4': binaryNumber.Append("0100"); break;
                case '5': binaryNumber.Append("0101"); break;
                case '6': binaryNumber.Append("0110"); break;
                case '7': binaryNumber.Append("0111"); break;
                case '8': binaryNumber.Append("1000"); break;
                case '9': binaryNumber.Append("1001"); break;
                case 'A': binaryNumber.Append("1010"); break;
                case 'B': binaryNumber.Append("1011"); break;
                case 'C': binaryNumber.Append("1100"); break;
                case 'D': binaryNumber.Append("1101"); break;
                case 'E': binaryNumber.Append("1110"); break;
                case 'F': binaryNumber.Append("1111"); break;
            }
        }
        Console.WriteLine("The Binary representation : {0}",binaryNumber.ToString());
    }
}

