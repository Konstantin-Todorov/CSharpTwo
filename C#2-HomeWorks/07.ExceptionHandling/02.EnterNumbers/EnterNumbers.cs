//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
using System;
class EnterNumbers
{
    static void Main()
    {
        try
        {
            Console.Write("Enter start number: ");
            int start = Int32.Parse(Console.ReadLine());
            Console.Write("Enter end number: ");
            int end = Int32.Parse(Console.ReadLine());
            ReadNumbers(start, end);
        }
        catch (FormatException formatEx)
        {
            Console.WriteLine(formatEx.Message);
        }
        catch (ArgumentOutOfRangeException outOfRange)
        {
            Console.WriteLine("Error " + outOfRange.Message);
        }
    }

    static void ReadNumbers(int start, int end)
    {
        for (int i = 0; i < 9; i++)
        {
            int numb = Int32.Parse(Console.ReadLine());
            if (numb < start || numb > end)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
    //static void Main()
    //{
    //    Console.WriteLine("Ten Runs : ");
    //    RunTenTimes(0, 100);
    //}
    //static void ReadNumbers(int start, int end)
    //{
    //    string input = Console.ReadLine();
    //    try
    //    {
    //        int number = int.Parse(input);
    //        if (number > start && number <end)
    //        {
    //            Console.WriteLine("The number {0} is in range. ",number);
    //        }
    //        else
    //        {
    //            throw new ArgumentOutOfRangeException();
    //        }
    //    }
    //    catch (ArgumentOutOfRangeException ex)
    //    {
    //        Console.WriteLine("Wrong input ! \n {0}",ex.Message);
    //    }
    //    catch (FormatException ex)
    //    {
    //        Console.WriteLine("Wrong input ! \n {0}",ex.Message);
    //    }
    //}
    //static void RunTenTimes(int start, int end)
    //{
    //    for (int i = 0; i < 10; i++)
    //    {
    //        RunTenTimes(start, end);
    //    }
    //}
}

