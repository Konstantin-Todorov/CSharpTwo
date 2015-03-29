//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
using System;
class LargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Enter the size of the array : ");
        int size = int.Parse(Console.ReadLine());
        int[] numbers = new int [size];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter a element in position [{0}] : ",i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter a position you want to check : ");
        int positionNumber = int.Parse(Console.ReadLine());
        while (positionNumber<0 || positionNumber>=size)
        {
            Console.Write("This position is not in the Array. Enter another one : ");
            positionNumber = int.Parse(Console.ReadLine());
        }
        bool neighbours = CheckIfLargerThanNeighbours(numbers, positionNumber);
        Console.WriteLine("Is it larger than its two neighbours : {0}", neighbours);
    }

    static bool CheckIfLargerThanNeighbours(int[] numbers, int positionNumber)
    {
        if (positionNumber>0 && positionNumber < numbers.Length - 1)
        {
            if ((numbers[positionNumber] > numbers[positionNumber+1]) && (numbers[positionNumber] > numbers[positionNumber-1]))
            {
                return true;
            }
        }
        return false;
    }
}
