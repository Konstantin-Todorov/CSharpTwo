﻿//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.
using System;
class SquareRoot
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter positive intiger number : ");
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}",Math.Sqrt(number));
        }
        catch 
        {
            Console.WriteLine("Invalid Number!");
        }
        finally
        {
            Console.WriteLine("Adios.");
        }
    }
}
