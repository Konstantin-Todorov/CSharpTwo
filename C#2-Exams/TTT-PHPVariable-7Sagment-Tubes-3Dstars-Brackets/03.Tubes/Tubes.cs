using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Tubes
{
    static void Main()
    {
        int tubes = int.Parse(Console.ReadLine());
        int friends = int.Parse(Console.ReadLine());
        long[] tubesSize = new long[tubes];
        long maxTube = 0;
        for (long i = 0; i < tubes; i++)
        {
            tubesSize[i] = long.Parse(Console.ReadLine());
            if (maxTube < tubesSize[i]) 
            {
                maxTube = tubesSize[i];
            }
        }
        long left = 1;
        long right = maxTube;
        long middle = (left + right) / 2;
        long finalResult = -1;
        while (left <= right) // BINARY SEARCH 
        {
            long eventual = 0;
            for (int j = 0; j < tubesSize.Length; j++)
            {
                eventual += tubesSize[j] / middle; 
            }
            if (eventual < friends)
            {
                right = middle - 1; 
            }
            else if (eventual >= friends)
            {
                left = middle + 1;
                finalResult = middle;
            }
            middle = (left + right) / 2;
        }
        Console.WriteLine(finalResult);
    }
}

