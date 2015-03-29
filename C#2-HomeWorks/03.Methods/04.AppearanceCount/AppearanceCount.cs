//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.
using System;
class AppearanceCount
{
    static void Main()
    {
        int[] numbers = { 1, 5, 11, 5, 3, 23, 7, 1, 1 };
        Console.Write("Enter number you want to search : ");
        int givenNumber = int.Parse(Console.ReadLine());
        int count = AppearanceOfNumberCount(numbers, givenNumber);
        Console.WriteLine("{0} appearce {1} times .",givenNumber,count);
    }

    static int AppearanceOfNumberCount(int[] numbers, int givenNumber)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i]==givenNumber)
            {
                count++;
            }
        }
        return count;
    }
}

