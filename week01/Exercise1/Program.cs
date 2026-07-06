using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is your first name? ");
        string first=Console.ReadLine();

        Console.WriteLine("what is your last name? ");
        string last=Console.ReadLine();

        Console.WriteLine( $" Your is name {last}, {first}, {last}");

    }
}