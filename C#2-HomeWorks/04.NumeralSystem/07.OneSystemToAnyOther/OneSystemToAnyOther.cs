//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
using System;
class OneSystemToAnyOther
{
    static void Main()
    {
        Console.Write("Enter number : ");
        string givenNumber = Console.ReadLine();
        Console.Write("Enter Base of the given number : ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Enter Base of the converted number : ");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine(FromBaseSToBaseD(givenNumber, s, d));
    }

    static string FromBaseSToBaseD(string givenNumber, int s, int d)
    {
        return DecimalToBaseD(BaseSToDecimal(givenNumber, s), d);
    }

    static string DecimalToBaseD(long number, int d = 2)
    {
        string result = String.Empty;
        while (number > 0)
        {
            result = GetChar(number % d) + result;
            number /= d;
        }
        return result;
    }

    static char GetChar(long number)
    {
        if (number >= 10)
        {
            return (char)(number + 'A' - 10);
        }
        return (char)(number + '0');
    }

    static long BaseSToDecimal(string givenNumber, int s = 2)
    {
        long number = 0;
        for (int i = givenNumber.Length - 1, j = 1; i >= 0; i--, j *= s)
        {
            number += GetNumber(givenNumber, i) * j;
        }
        return number;
    }

    static int GetNumber(string givenNumber, int i)
    {
        if (givenNumber[i] > 'A')
        {
            return givenNumber[i] - 'A' + 10;
        }
        return givenNumber[i] - '0';
    }
}
