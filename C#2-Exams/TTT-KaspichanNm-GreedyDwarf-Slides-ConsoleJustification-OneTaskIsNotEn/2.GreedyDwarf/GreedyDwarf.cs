using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
class GreedyDwarf
{
    static void Main()
    {
        string[] rawNumbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int[] vallyNumbers = new int[rawNumbers.Length];
        for (int i = 0; i < vallyNumbers.Length; i++)
        {
            vallyNumbers[i] = int.Parse(rawNumbers[i]);
        }
        int numbersOfPattern = int.Parse(Console.ReadLine());
        long bestSum = long.MinValue;
        for (int i = 0; i < numbersOfPattern; i++)
        {
           long sum = (ProcessPattern(vallyNumbers));
           if (sum > bestSum)
           {
               bestSum = sum;
           }
        }
        Console.WriteLine(bestSum);
    }
    static long ProcessPattern(int[] vally)
    {
        string[] rawNumbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int[] pattern = new int[rawNumbers.Length];
        for (int i = 0; i < pattern.Length; i++)
        {
            pattern[i] = int.Parse(rawNumbers[i]);
        }

        bool[] visited = new bool[vally.Length];
        long coinSum = 0;
        coinSum += vally[0];
        visited[0] = true;
        int currentPosition = 0;

        while (true)
        {
            for (int i = 0; i < pattern.Length; i++)
            {
                int nextMove = currentPosition + pattern[i];
                if (nextMove >= 0 && nextMove < vally.Length && !visited[nextMove])
                {
                    coinSum += vally[nextMove];
                    visited[nextMove] = true;
                    currentPosition = nextMove;
                }
                else
                {
                    return coinSum;
                }
            }
        }
        return 0;

    }
}
