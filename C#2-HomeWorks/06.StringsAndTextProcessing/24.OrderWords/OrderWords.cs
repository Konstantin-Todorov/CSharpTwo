using System;
using System.Linq;
class OrderWords
{
    static void Main()
    {
        Console.Write("Enter words : ");
        string[] words = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(words);
        Console.WriteLine("Sorted words : \n{0}",string.Join("\n",words.Select(w => string.Format("{0}",w))));
    }
}
