using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class EncodeAndEncrypt
{
    static void Main()
    {
        string message = Console.ReadLine();
        string cypher = Console.ReadLine();

        StringBuilder encryptedMessage = Encrypt(message, cypher);
        encryptedMessage.Append(cypher);
        StringBuilder encodedAndEncryptMessage = Encode(encryptedMessage);
        Console.WriteLine(encodedAndEncryptMessage.ToString() + cypher.Length);
    }

    private static StringBuilder Encode(StringBuilder message)
    {
        StringBuilder encodedTextBuilder = new StringBuilder(message.Length);
        int indexInMessage = 0;
        while (indexInMessage < message.Length)
        {
            char currentSymbol = message[indexInMessage];
            int scanIndex = indexInMessage + 1;
            int repeatLength = 1;
            while (scanIndex < message.Length &&
                message[scanIndex] == currentSymbol)
            {
                repeatLength++;
                scanIndex++;
            }

            indexInMessage = scanIndex;
            if (repeatLength > 2)
            {
                encodedTextBuilder.Append(repeatLength);
                encodedTextBuilder.Append(currentSymbol);
            }
            else
            {
                encodedTextBuilder.Append(new string(currentSymbol, repeatLength));
            }
        }

        return encodedTextBuilder;
    }

    private static StringBuilder Encrypt(string message, string cypher)
    {
        StringBuilder encrypted = new StringBuilder(message);

        int maxLenght = Math.Max(message.Length , cypher.Length);

        for (int i = 0; i < maxLenght; i++)
        {
            char messageSymbol = encrypted[i % encrypted.Length];
            char cypherSymbol = cypher[i % cypher.Length];

            int messageSymbolValue = messageSymbol - 'A';
            int cypherSymbolValue = cypherSymbol - 'A';

            int result = (messageSymbolValue ^ cypherSymbolValue) + 'A';
            encrypted[i % encrypted.Length] = (char)result;
        }
        return encrypted;
    }
}
