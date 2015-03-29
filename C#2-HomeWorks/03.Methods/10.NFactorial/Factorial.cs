//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
using System;
using System.Numerics;
class Factorial
{
    static void Main()
    {
        int[] numbers = new int [100];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 1;
        }
        FactorialOfN(numbers);
    }

    static void FactorialOfN(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            BigInteger factorial = FactorialCalculating(numbers[i]);
            Console.WriteLine(factorial);
        }
    }

    static BigInteger FactorialCalculating(int i)
    {
        BigInteger factorial = i;
        while (i > 1)
        {
            factorial *= i - 1;
            i--;
        }
        return factorial;
    }
}

