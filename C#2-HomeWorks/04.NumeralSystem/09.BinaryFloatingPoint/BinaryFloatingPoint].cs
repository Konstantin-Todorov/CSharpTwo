//Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float).
//Example:
//   number	  sign	     exponent	        mantissa
//   -27,25	   1	     10000011	  10110100000000000000000
using System;
using System.Text;
using System.Globalization;
using System.Threading;
class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Floating point with single precision : ");
        float number = float.Parse(Console.ReadLine());
        StringBuilder binaryNumber = new StringBuilder();
        int mask = 0;
        unsafe
        {
            int* pointer = (int*)&number;
            mask = *pointer;
        }
        for (int i = 0; i < 32; i++)
        {
            if ((mask & 1) == 0)
            {
                binaryNumber.Insert(0, '0');
            }
            else
            {
                binaryNumber.Insert(0, '1');
            }
            mask >>= 1;
        }
        Console.WriteLine("The number in Binary : {0}",binaryNumber);
        string binaryNumToString = binaryNumber.ToString();
        Console.WriteLine("Sign : {0}\nExponent : {1}\nMantissa : {2}",binaryNumToString[0],binaryNumToString.Substring(1,8),binaryNumToString.Substring(9));
    }
}
