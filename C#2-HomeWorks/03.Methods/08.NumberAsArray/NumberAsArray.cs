//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.
using System;
using System.Numerics;
class NumberAsArray
{
    static void Main()
    {
        Console.Write("Enter first positive integer number: ");
        string input = Console.ReadLine();
        int[] firstNumberArray = new int[input.Length];

        for (int i = 0; i < firstNumberArray.Length; i++)
        {
            firstNumberArray[i] = int.Parse(input[input.Length - 1 - i].ToString());
        }

        Console.Write("Enter second positive integer number: ");
        input = Console.ReadLine();
        int[] secondNumberArray = new int[input.Length];

        for (int i = 0; i < secondNumberArray.Length; i++)
        {
            secondNumberArray[i] = int.Parse(input[input.Length - 1 - i].ToString());
        }
        Console.Write("Ads of number is : ");
        PrintNumber(SumOfDigitOfNumber(firstNumberArray, secondNumberArray));
    }

    static void PrintNumber(int[] result)
    {
        for (int i = result.Length - 1; i >= 0; i--)
        {
            if (result[i] == 0 && i == result.Length - 1)
            {
                continue;
            }
            Console.WriteLine(result[i]);
        }
        Console.WriteLine();
    }

    static int[] SumOfDigitOfNumber(int[] firstNumberArray, int[] secondNumberArray)
    {
        if (firstNumberArray.Length > secondNumberArray.Length)
        {
            return SumOfDigitOfNumber(secondNumberArray, firstNumberArray);
        }
        int[] result = new int[secondNumberArray.Length];
        int otherDigits = 0;

        for (int i = 0; i < firstNumberArray.Length; i++)
        {
            result[i] = firstNumberArray[i] + secondNumberArray[i] + otherDigits;
            otherDigits = result[i] / 10;
            result[i] &= 10;
        }
        for (int i = 0; i < secondNumberArray.Length && otherDigits != 0; i++)
        {
            result[i] = secondNumberArray[i] + otherDigits;
            otherDigits = result[i] / 10;
            result[i] &= 10;
        }
        for (int i = 0; i < secondNumberArray.Length; i++)
        {
            result[i] = secondNumberArray[i];
        }
        if (otherDigits != 0)
        {
            int i = 0;
            result[i] = 1;
        }
        else
        {
            Array.Resize(ref result, result.Length - 1);
        }
        return result;
    }
}
