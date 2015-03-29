using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class SevenSagmentDisplay
{
    static int N;
    static byte[] sagments;
    static char[] currentAnswer;
    static readonly List<string> answers = new List<string>();

    static void Main()
    {
        N = int.Parse(Console.ReadLine());
        sagments = new byte[N];
        currentAnswer = new char[N];
        for (int i = 0; i < N; i++)
        {
            sagments[i] = Convert.ToByte(Console.ReadLine(), 2); 
        }
        SolveWithRecursion(0);
        Console.WriteLine(answers.Count);
        foreach (var answer in answers)
        {
            Console.WriteLine(answer);
        }
    }
    static readonly byte[] digits = new byte[10]
    {
            Convert.ToByte("1111110", 2), // 0
            Convert.ToByte("0110000", 2), // 1
            Convert.ToByte("1101101", 2), // 2
            Convert.ToByte("1111001", 2), // 3
            Convert.ToByte("0110011", 2), // 4
            Convert.ToByte("1011011", 2), // 5
            Convert.ToByte("1011111", 2), // 6
            Convert.ToByte("1110000", 2), // 7
            Convert.ToByte("1111111", 2), // 8
            Convert.ToByte("1111011", 2), // 9
    };

    private static void SolveWithRecursion(int numberPosition)
    {
        if (numberPosition == N)
        {
            answers.Add(new string(currentAnswer));
            return;
        }
        for (int i = 0; i < digits.Length; i++)
        {
            if ((digits[i] & sagments[numberPosition]) == sagments[numberPosition]) 
            {
                currentAnswer[numberPosition] = (char)('0' + i);
                SolveWithRecursion(numberPosition + 1);
            }
        }
    }
}