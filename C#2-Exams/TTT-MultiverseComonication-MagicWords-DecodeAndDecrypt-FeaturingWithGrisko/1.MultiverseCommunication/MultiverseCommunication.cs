using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MultiverseCommunication
{
    static void Main()
    {
        var alphabet = new List<string> { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };
        var input = Console.ReadLine();
        var decimalRepresentation = 0L;
        for (int i = 0; i < input.Length; i += 3) 
        {
            var digitIn13 = input.Substring(i, 3);
            var decimalValue = alphabet.IndexOf(digitIn13);
            decimalRepresentation *= 13;
            decimalRepresentation += decimalValue;
        }
        Console.WriteLine(decimalRepresentation);
    }
}