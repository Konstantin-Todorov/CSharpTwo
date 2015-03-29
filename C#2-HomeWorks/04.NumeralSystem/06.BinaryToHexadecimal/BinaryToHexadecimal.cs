//Write a program to convert binary numbers to hexadecimal numbers (directly).
using System;
using System.Text;
class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter Binary number : ");
        string binaryNumber = Console.ReadLine();
        string finalBinaryNumber = BinaryToHexadecimalStr(binaryNumber.PadLeft(4, '0'));
        Console.WriteLine("The Hexadecimal representation : {0} ",finalBinaryNumber);
    }
    static string BinaryToHexadecimalStr(string binaryNumber)
    {
        int stringLenght = binaryNumber.Length;
        StringBuilder binaryString = new StringBuilder();
        for (int i = 0; i < stringLenght; i = i + 4)
        {
            switch (binaryNumber.Substring(i, 4))
            {
                case "1010": binaryString.Append('A'); break;
                case "1011": binaryString.Append('B'); break;
                case "1100": binaryString.Append('C'); break;
                case "1101": binaryString.Append('D'); break;
                case "1110": binaryString.Append('E'); break;
                case "1111": binaryString.Append('F'); break;
                case "0000": binaryString.Append('0'); break;
                case "0001": binaryString.Append('1'); break;
                case "0010": binaryString.Append('2'); break;
                case "0011": binaryString.Append('3'); break;
                case "0100": binaryString.Append('4'); break;
                case "0101": binaryString.Append('5'); break;
                case "0110": binaryString.Append('6'); break;
                case "0111": binaryString.Append('7'); break;
                case "1000": binaryString.Append('8'); break;
                case "1001": binaryString.Append('9'); break;
            }
        }
        return binaryString.ToString();
    }
}
