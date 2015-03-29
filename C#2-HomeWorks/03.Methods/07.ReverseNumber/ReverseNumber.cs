//Write a method that reverses the digits of given decimal number.
//Example:

//input	output
//256	652
//123.45	54.321
using System;
using System.Globalization;
using System.Threading;

class ReverseNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter a decimal number : ");
        decimal decimalNumber = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Reversed : {0}",RevercedDecimalNumber(decimalNumber));
    }

    static decimal RevercedDecimalNumber(decimal decimalNumber)
    {
        char[] temp = decimalNumber.ToString().ToCharArray();
        char[] reversedNumber = new char[temp.Length];
        for (int i = 0; i < temp.Length; i++)
        {
            reversedNumber[temp.Length - i - 1] = temp[i];
        }
        return decimal.Parse(new String(reversedNumber));
    }
}
