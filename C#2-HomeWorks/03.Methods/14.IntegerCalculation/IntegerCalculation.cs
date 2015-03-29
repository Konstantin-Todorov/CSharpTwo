//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.
using System;
class IntegerCalculation
{
    static void Main()
    {
        Console.WriteLine("Min : {0}",Min(2,3,1,4));
        Console.WriteLine("Max : {0}", Max(2, 3, 1, 4));
        Console.WriteLine("Average : {0}", Average(2, 3, 1, 4));
        Console.WriteLine("Sum : {0}", Sum(2, 3, 1, 4));
        Console.WriteLine("Product : {0}", Product(2, 3, 1, 4));
    }

    static int Min(params int[] sequence)
    {
        int minElement = int.MaxValue;
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] < minElement)
            {
                minElement = sequence[i];
            }
        }
        return minElement;
    }

    static int Max(params int[] sequence)
    {
        int maxElement = int.MinValue;
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i]>maxElement)
            {
                maxElement = sequence[i];
            }
        }
        return maxElement;
    }

    static double Average(params int[] sequance )
    {
        return Sum(sequance)/sequance.Length;
    }

    static double Sum(params int [] sequence)
    {
        double sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }
        return sum;
    }

    static double Product(params int [] sequence)
    {
        int product = 1;
        for (int i = 0; i < sequence.Length; i++)
        {
            product *= sequence[i];
        }
        return product;
    }


}

