//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
using System;
class SortByStringLenght
{
    static void Main()
    {
        Console.Write("N : ");
        int n = int.Parse(Console.ReadLine());
        var array = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter array[{0}]: ", i);
            array[i] = Console.ReadLine();
        }
        //Lambda Sort
        Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Array[{0}] = {1} ", i, array[i]);
        }
    }
}
