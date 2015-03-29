//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
using System;
class GetLargestNumber
{
    static void Main()
    {
        var numbers = new int[3];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number {0} : ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The Largest Number is : {0}", GetMax(GetMax(numbers[0], numbers[1]), numbers[2]));
    }
    static int GetMax(int a, int b)
    {
        int largestNumber = 0;
        if (a > b)
        {
            largestNumber = a;
        }
        else
        {
            largestNumber = b;
        }
        return largestNumber;
    }
}
