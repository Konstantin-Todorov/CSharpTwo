 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Crosswords
{
    class Program
    {
        static HashSet<string> allWords = new HashSet<string>();
        static string[] words;
        static string[] crossword;
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            words = new string[N + N];
            crossword = new string[N];
            for (int i = 0; i < N + N; i++)
            {
                words[i] = Console.ReadLine();
                allWords.Add(words[i]);
            }
            Array.Sort(words);
            Solver(0);
            Console.WriteLine("NO SOLUTION!");
        }
        static void Solver(int indexLine)
        {
            if (indexLine >= crossword.Length)
            {
                if (CheckVertical())
                {
                    Printer();
                    Environment.Exit(0);
                }
                return;

            }
            for (int i = 0; i < words.Length; i++)
            {
                crossword[indexLine] = words[i];
                Solver(indexLine + 1);
                crossword[indexLine] = null;
            }
        }
        static void Printer()
        {
            for (int i = 0; i < crossword.Length; i++)
            {
                Console.WriteLine(crossword[i]);
            }
        }
        static bool CheckVertical()
        {
            StringBuilder currentWord = new StringBuilder();
            for (int i = 0; i < crossword.Length; i++)
            {
                currentWord.Clear();  
                for (int j = 0; j < crossword.Length; j++)
                {
                    currentWord.Append(crossword[j][i]);
                }
                if (!allWords.Contains(currentWord.ToString()))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
