//Describe the strings in C#.
//What is typical for the string data type?
//Describe the most important methods of the String class.
using System;
using System.Text;
class StringInCSharp
{
    static void Main()
    {
        Console.Write("1.Describe the strings in C#. : \n");
        DescribeTheString();
        Console.Write("2.What is typical for the string data type ? : \n");
        TypicalForStrings();
        Console.Write("3.Describe the most important methods of the String class. : \n");
        ImportantMethods();
    }

    static void ImportantMethods()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("Most important string processing members are:");
        stringBuilder.AppendLine("    -Length, this[], Compare(str1, str2), IndexOf(str), LastIndexOf(str),\n      Substring(startIndex, length), Replace(oldStr, newStr),\n      Remove(startIndex, length), ToLower(), ToUpper(), Trim()");
        Console.WriteLine(stringBuilder);
    }

    static void TypicalForStrings()
    {
        StringBuilder stringBuileder = new StringBuilder();
        stringBuileder.AppendLine("System.String is reference type");
        stringBuileder.AppendLine("String objects are like arrays of characters (char[])");
        stringBuileder.AppendLine("    -Have fixed length (String.Length)");
        stringBuileder.AppendLine("    -Elements can be accessed directly by index (the index is in the range [0..Length-1])");
        Console.WriteLine(stringBuileder);
    }

    static void DescribeTheString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("Strings are immutable sequences of characters \n (instances of the System.String Class in .NET Framework)");
        stringBuilder.AppendLine("    -Declared by the keyword string in C#");
        stringBuilder.AppendLine("    -Can be initialized by string literals");
        stringBuilder.AppendLine("    -Use Unicode to support multiple languages and alphabets");
        stringBuilder.AppendLine("    -Stored in the dynamic memory (managed heap)");
        Console.WriteLine(stringBuilder);
    }
}

