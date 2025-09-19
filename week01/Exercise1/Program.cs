using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for the user their names
        Console.Write("what is your first name?");
        string first = Console.ReadLine();
        Console.Write("what is your last name?");
        string last = Console.ReadLine();

        Console.WriteLine($"Hello, your name is {last}, {first} {last}");
    }
}
