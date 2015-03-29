﻿//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
//Example:

//input	output
//"43 68 9 23 318"	461
using System;
using System.Linq;
class SumIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter a sequence of positive integer separated by space ' ' : ");
        string inputString = Console.ReadLine();
        long[] numbers = inputString.Split(' ').Select(long.Parse).ToArray();
        Console.WriteLine(numbers.Sum());
    }
}