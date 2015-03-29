using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class TRES4Numbers
{
    static void Main(string[] args)
    {
        var digits = new[] { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };
        ulong numebrInDecimal = ulong.Parse(Console.ReadLine());
        StringBuilder result = new StringBuilder();
        if (numebrInDecimal == 0)
        {
            Console.WriteLine(digits[0]);
        }
        while (numebrInDecimal > 0)
        {
            int numberIn9th = (int)(numebrInDecimal % 9);
            result.Insert(0, digits[numberIn9th]);
            numebrInDecimal /= 9;
        }
        Console.WriteLine(result.ToString());
    }
}