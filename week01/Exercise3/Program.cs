using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int random = randomGenerator.Next(1, 11);
        int number = 0;

        do
        {
        Console.Write("What's you guess? ");
        string numberInput = Console.ReadLine();
        number = int.Parse(numberInput);

        if (number < random)
        {
            Console.WriteLine("Higher");
        }
        else if (number > random)
        {
            Console.WriteLine("Lower");
        }   
        } while (number != random);

        if (number == random)
        {
            Console.WriteLine("You guess it!");
        }
        
    }
}