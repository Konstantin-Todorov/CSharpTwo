//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.
using System;
class SortingArray
{
    static void Main()
    {
        int[] numbers = { 10 , 23 , 17 , 25 , 71 , 40 , 56 ,72 , 84 , 22 };
        SortDecending(numbers);
        PrintSortedArray(numbers);
        SortAscendingAndPrint(numbers);
    }

    static void SortAscendingAndPrint(int[] numbers)
    {
        int[] newNumbers = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            newNumbers[i] = numbers[numbers.Length - i - 1];
        }
        PrintSortedArray(newNumbers);
    }

    static void PrintSortedArray(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 10 == 0)
            {
                Console.WriteLine();
            }
            Console.WriteLine(numbers[i]);
        }
        Console.WriteLine();
    }

    static void SortDecending(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            int max = FindMaxIndex(numbers, i);
            int temp = numbers[i];
            numbers[i] = numbers[max];
            numbers[max] = temp;
        }
    }

    static int FindMaxIndex(int[] numbers, int startIndex)
    {
        int currentMax = int.MinValue;
        int currentMaxIndex = startIndex;

        for (int i = startIndex; i < numbers.Length; i++)
        {
            if (currentMax < numbers[i])
            {
                currentMax = numbers[i];
                currentMaxIndex = i;
            }
        }
        return currentMaxIndex;
    }
}

