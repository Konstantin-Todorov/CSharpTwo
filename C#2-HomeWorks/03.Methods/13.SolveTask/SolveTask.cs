//Write a program that can solve these tasks:
// -Reverses the digits of a number
// -Calculates the average of a sequence of integers
// -Solves a linear equation a * x + b = 0
//------------------------------------------------------
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
// -The decimal number should be non-negative
// -The sequence should not be empty
// -a should not be equal to 0
using System;
using System.Collections.Generic;
class SolveTask
{
    static void Main()
    {
        Console.WriteLine("Select a task that you want to solve : ");
        Console.WriteLine("1. Reverse the digits of a number      ");
        Console.WriteLine("2. Calculate Average                   ");
        Console.WriteLine("3. Solve linear equation a * x + b = 0 ");
        Console.Write("Your choice is : ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: ReverseDigits(); break;
            case 2: CalculateAverage(); break;
            case 3: SolveEqation(); break;
            default: Console.WriteLine("Choose 1 2 or 3!"); break;
        }
    }

    static void ReverseDigits()
    {
        Console.Write("Enter number : ");
        string number = Console.ReadLine();
        if (decimal.Parse(number) > 0)
        {
            Console.WriteLine("The reversed number is {0} " , Reverse(number));
        }
        else
        {
            Console.WriteLine("The number must be non-negative!");
        }
    }

    static decimal Reverse(string number)
    {
        char[] reversingNumber = number.ToCharArray();
        Array.Reverse(reversingNumber);
        string reversedNumber = new string(reversingNumber);
        decimal finalNumber = decimal.Parse(reversedNumber);
        return finalNumber;
    }

    static void CalculateAverage()
    {
        Console.Write("Enter size of sequence: ");
        int size = int.Parse(Console.ReadLine());

        if (size <= 0)
        {
            Console.WriteLine("The sequence must have at least 1 element !");
            return;
        }
        int[] sequence = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("sequence [{0}] = ", i);
            sequence[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The avarage sequence is : {0}", AvarageSequence(sequence));

    }

    static double AvarageSequence(int[] sequence)
    {
        int sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }
        return (double)sum / sequence.Length;
    }

    static void SolveEqation()
    {
        Console.Write("Enter a : ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b : ");
        int b = int.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("a should not be equal to 0");
        }
        else
        {
            Console.WriteLine("Equation = {0}", CalcolateEquation(a, b));
        }
    }

    static double CalcolateEquation(double a, double b)
    {
        return (double)-b / a;
    }
}
