//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
using System;
class BinaryShort
{
    static void Main()
    {
        Console.Write("Enter number from {0} to {1} : ", short.MinValue, short.MaxValue);
        short number = short.Parse(Console.ReadLine());
        Console.WriteLine("{0} in Binary : {1}", number, ToBinary(number));
    }

    static object ToBinary(short number)
    {
        string binary = string.Empty;
        for (int i = 15; i >= 0; i--)
        {
            binary = ((number % 2) & 1) + binary;
            number >>= 1;
            if (i % 4 == 0)
            {
                binary = " " + binary;
            }
        }
        return binary;
    }
}
