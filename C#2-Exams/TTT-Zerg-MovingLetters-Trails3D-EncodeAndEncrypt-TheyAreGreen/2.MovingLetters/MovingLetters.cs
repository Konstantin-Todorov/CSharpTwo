using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MovingLetters
{
    class MovingLetters
    {
        static StringBuilder ExtractLetters (string[] words)
        {
            StringBuilder result = new StringBuilder();
            int maxWordLenght = 0;

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                if (maxWordLenght < currentWord.Length)
                {
                    maxWordLenght = currentWord.Length;
                }
            }
            for (int i = 0; i < maxWordLenght; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    string currentWord = words[j];
                    if (i < currentWord.Length)
                    {
                        int lastLetter = currentWord.Length - 1 - i;
                        result.Append(currentWord[lastLetter]);
                    }
                }
            }
            return result;
        }
        static string MoveWords ( StringBuilder strangePieceOfWords)
        {
            for (int i = 0; i < strangePieceOfWords.Length; i++)
            {
                char currentSymbol = strangePieceOfWords[i];
                int transition = char.ToLower(currentSymbol) - 'a' + 1;
                strangePieceOfWords.Remove(i, 1);
                int nextPosition = (i + transition) % (strangePieceOfWords.Length + 1);
                strangePieceOfWords.Insert(nextPosition, currentSymbol);
            }
            return strangePieceOfWords.ToString();
        }
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            StringBuilder strangeCombinationOfLetters = ExtractLetters(words);
            string finalResult = MoveWords(strangeCombinationOfLetters);
            Console.WriteLine(finalResult);
        }
    }
}
