//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string
//with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
using System;
class EncodingDecoding
{
    static void Main()
    {
        Console.Write("Enter a text : ");
        string text = Console.ReadLine();
        Console.Write("Enter a key : ");
        string key = Console.ReadLine();
        char[] code = text.ToCharArray();
        for (int i = 0; i < code.Length; i++)
        {
            for (int j = 0; j < key.Length; j++)
            {
                code[i] ^= key[j]; 
            }
        }
        text = new string(code);
        Console.WriteLine(text);
    }
}
