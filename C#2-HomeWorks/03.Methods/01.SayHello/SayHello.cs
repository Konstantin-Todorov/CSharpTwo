//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.
//Example:

//input	output
//Peter	Hello, Peter!
using System;
    class SayHello
    {
        static void Main()
        {
            Console.Write("Enter your first name : ");
            string name = Console.ReadLine();
            PrintHello(name);
        }
        static void PrintHello(string name)
        {
            Console.WriteLine("Hello , {0}!" , name);
        }
    }

