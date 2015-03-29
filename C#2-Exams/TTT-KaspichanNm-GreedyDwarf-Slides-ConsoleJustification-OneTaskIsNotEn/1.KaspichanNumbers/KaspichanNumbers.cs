using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class KaspichanNumbers
{
    static void Main()
    {
        ulong N = ulong.Parse(Console.ReadLine());
        List<string> digits = new List<string>();
        for (char i = 'A'; i <= 'Z'; i++)
        {
            digits.Add(i.ToString());
        }
        for (char i = 'a'; i <= 'i'; i++)
        {
             for (char j = 'A'; j <= 'Z'; j++)
            {
                digits.Add(i.ToString() + j.ToString());
            }
        }
        string result = string.Empty;
        if (N == 0)
        {
            Console.WriteLine('A');
        }
        while (N != 0) 
        {
            result = digits[(int)(N % 256)] + result;
            N = N / 256;
        }
        Console.WriteLine(result);
    }
}
