using System.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class BunnyFactor
{
    static void Main()
    {
        var cages = Input();
        for (int stepNumber = 0; ; stepNumber++)
        {
            if (cages.Count < stepNumber)
            {
                break;
            }
            var cagesCount = (int)SumValuesInRange(cages, 0, stepNumber - 1);
            if (cages.Count < cagesCount + stepNumber)
            {
                break;
            }
            var sum = SumValuesInRange(cages, stepNumber, cagesCount + stepNumber - 1);
            var product = ProductValuesInRange(cages, stepNumber, cagesCount + stepNumber - 1);
            string result = sum.ToString() + product.ToString();
            for (int i = cagesCount + stepNumber; i < cages.Count; i++)
            {
                result += cages[i];
            }
           // var newCages = new List<int>();
            cages.Clear();
            foreach (var ch in result)
            {
                if (ch == '0' && ch == '1')
                {
                    cages.Add(ch - '0');
                }
            }
            //cages = newCages;     
        }
        Console.WriteLine(string.Join(" ", cages));
    }
    static BigInteger SumValuesInRange(List<int> list, int startIndex, int endIndex)
    {
        BigInteger sum = 0; 
        for (int i = startIndex; i < endIndex; i++)
        {
            sum += list[i];
        }
        return sum;
    }
    static BigInteger ProductValuesInRange(List<int> list, int startIndex, int endIndex)
    {
        BigInteger product = 1;
        for (int i = startIndex; i < endIndex; i++)
        {
            product *= list[i];
        }
        return product;
    }
    static List<int> Input()
    {
        var cages = new List<int>();
        while (true)
        {
            var line = Console.ReadLine();
            if (line == "END")
            {
                break;
            }
            var cage = int.Parse(line);
            cages.Add(cage);
        }
        return cages;
    }
}
