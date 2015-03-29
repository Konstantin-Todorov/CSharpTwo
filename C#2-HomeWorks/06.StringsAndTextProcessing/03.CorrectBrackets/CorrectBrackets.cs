//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
using System;
class CorrectBrackets
{
    static void Main()
    {
        Console.WriteLine("Enter expression : ");
        string expression = Console.ReadLine();
        Console.WriteLine(CheckIfExpressionIsValid(expression) ? "The Expression is Valid" : "The Expression is Incorrect");
    }

    static bool CheckIfExpressionIsValid(string expression)
    {
        const char leftBrackets = '(';
        const char rightBrackets = ')';
        int bracketsCount = 0;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == leftBrackets)
            {
                bracketsCount++;
            }
            else if (expression[i] == rightBrackets)
            {
                bracketsCount--;
            }
            else if (bracketsCount == 0)
            {
                return true;
            }
        }
        return false;
    }
}

