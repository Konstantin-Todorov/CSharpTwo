//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.
using System;
class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Enter the size of the array : ");
        int size = int.Parse(Console.ReadLine());
        int[] numbers = new int[size];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter a element in position [{0}] : ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int neighbours = CheckIfLargerThanNeighbours(numbers);
    }

    static int CheckIfLargerThanNeighbours(int[] numbers)
    {
        for (int i = 1; i < numbers.Length - 1; i++)
        {
            if (numbers[i-1]<numbers[i] && numbers[i+1]<numbers[i])
            {
                return i;
            }
        }
        return -1;
    }
}

