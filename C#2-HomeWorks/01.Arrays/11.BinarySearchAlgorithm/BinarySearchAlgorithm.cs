//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
using System;
class BinarySearchAlgorithm
{
    static int BinSearch(int[] arr, int key)
    {
        Array.Sort(arr);
        int first = 0;
        int last = arr.Length - 1;
        while (last >= first)
        {
            int mid = (first + last) / 2;
            if (arr[mid] < key)
            {
                first = mid + 1;
            }
            else if (arr[mid] > key)
            {
                last = mid - 1;
            }
            else
            {
                return mid;
            }
        }
        return -1;
    }
    static void Main()
    {
        Console.WriteLine("Binary search algorith.");
        int[] sortedArr = new int[8] { 7, 2, 51, 4, 3, 13, 8, 21 };
        int key = 4;
        Console.WriteLine(BinSearch(sortedArr, key));
    }
}

