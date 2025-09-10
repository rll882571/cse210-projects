using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Whait is your first name? ");
        string first = Console.ReadLine();

        Console.Write("Whait is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}