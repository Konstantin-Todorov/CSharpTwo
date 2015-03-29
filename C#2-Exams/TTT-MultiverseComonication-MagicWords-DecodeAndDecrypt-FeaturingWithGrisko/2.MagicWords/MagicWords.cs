using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MagicWords
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var words = new List<string>();
        for (int i = 0; i < n; i++)
        {
            words.Add(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            var word = words[i];
            var newIndex = word.Length % (n + 1);
            words.Insert(newIndex, word);
            if (newIndex < 1)
            {
                words.RemoveAt(i + 1);
            }
            else
            {
                words.RemoveAt(i);
            }
        }
        var maxLenght = 0;
        foreach (var word in words)
        {
            maxLenght = Math.Max(maxLenght, word.Length);
        }
        var result = new StringBuilder();
        for (int i = 0; i < maxLenght; i++)
        {
            foreach (var word in words)
            {
                if (word.Length > i)
                {
                    result.Append(word[i]);
                }
            }
        }
        Console.WriteLine(result.ToString());
    }
}   
 