//Write a program that finds the maximal increasing sequence in an array.
//Example:

//input	result
//3, 2, 3, 4, 2, 2, 4	2, 3, 4

using System;
class MaxIncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int n = int.Parse(Console.ReadLine());
        int bestSeq = 1;
        int currSeq = 1;
        string currNum = string.Empty;
        string bestNum = string.Empty;
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n - 1; i++)
        {
            if (arr[i] < arr[i + 1])
            {
                currSeq++;
                currNum += arr[i] + " ";
            }
            else
            {
                if (currSeq > bestSeq)
                {
                    bestSeq = currSeq;
                    currNum += arr[i] + " ";
                    bestNum = currNum;
                }
                currSeq = 1;
                currNum = string.Empty;
            }
        }
        if (currSeq > bestSeq)
        {
            currNum += arr[arr.Length - 1];
            bestNum = currNum;
        }
        Console.WriteLine(bestNum);
    }
}
