//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).
using System;
using System.Collections.Generic;
using System.Linq;
class NumberCalculation
{
    static void Main()
    {
        Console.WriteLine("Min : {0}", Min(2, 3, 1, 4));
        Console.WriteLine("Max : {0}", Max(2, 3, 1, 4));
        Console.WriteLine("Average : {0}", Average(2, 3, 1, 4));
        Console.WriteLine("Sum : {0}", Sum(2, 3, 1, 4));
        Console.WriteLine("Product : {0}", Product(2, 3, 1, 4));
    }
    static K Min<K> (params K[] numbers ) where K : IComparable<K>
    {
        int minIndex = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i].CompareTo(numbers[minIndex]) == -1) minIndex = i;
        }
        return numbers[minIndex];
    }
    static K Max<K>(params K[] numbers) where K : IComparable<K>
    {
        int maxIndex = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i].CompareTo(numbers[maxIndex]) == 1) maxIndex = i;
        }
        return numbers[maxIndex];
    }
    static K Sum<K>(params K[] numbers) where K : IComparable<K>
    {
        return numbers.Aggregate<K, dynamic>(0, (current, t) => current + t);
    }

    static float Average<K>(params K[] numbers) where K : IComparable<K>
    {
        dynamic averageSum = numbers.Aggregate<K, dynamic>(0, (current, t) => current + t);
        return averageSum / numbers.Length;
    }

    static K Product<K>(params K[] numbers) where K : IComparable<K>
    {
        return numbers.Aggregate<K, dynamic>(1, (current, t) => current * t);
    }
}

