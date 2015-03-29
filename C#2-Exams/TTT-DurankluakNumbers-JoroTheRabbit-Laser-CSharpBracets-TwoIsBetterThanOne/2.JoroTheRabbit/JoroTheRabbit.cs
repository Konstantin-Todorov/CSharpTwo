using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class JoroTheRabbit
{
    static void Main()
    {
        int[] numbers;
        string input = Console.ReadLine();
        string[] inputNumbers = input.Split(new char[] { ' ',',' }, StringSplitOptions.RemoveEmptyEntries);
        numbers = new int[inputNumbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(inputNumbers[i]);

        }
        int bestPath = 0;
        for (int startIndex = 0; startIndex < numbers.Length; startIndex++)
        {
            for (int steps = 1; steps < numbers.Length; steps++)
            {
                int index = startIndex;
                int currentPath = 1;
                int nextPath = (index + steps) % numbers.Length;
                while ( numbers[index] < numbers[nextPath]) 
                {
                    currentPath++;
                    index = nextPath;
                    nextPath = (index + steps) % numbers.Length;
                }
                if (bestPath<currentPath)
                {
                    bestPath = currentPath;
                }
            }
        }
        Console.WriteLine(bestPath);
    }
}
