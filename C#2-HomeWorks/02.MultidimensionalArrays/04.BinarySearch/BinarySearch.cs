//Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
using System;
class BinarySearch
{
    static void Main()
    {
        Console.Write("N: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter element[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter integer number K :");
        int k = int.Parse(Console.ReadLine());

        Array.Sort(array);

        if (array[0] > k)
        {
            Console.WriteLine("There isn`t number which is <= K");
        }
        
        while (Array.BinarySearch(array, k) < 0)
        {
            k--;
        }
        Console.WriteLine("Largest number which is <= K is :" + k);
    }
}
