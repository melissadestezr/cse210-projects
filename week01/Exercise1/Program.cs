using System;

class Program //james bond program
{
    static void Main(string[] args)
    {
        Console.Write("What is your fisrt name? ");
        string firstname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {lastname} {firstname}, {lastname}");
    }
}