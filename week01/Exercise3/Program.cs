using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int random = randomGenerator.Next(1, 100);
        int number = 0;
        string answer = "";
        int guess = 0;
        

        do
        {
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

            guess++;

            } while (number != random);

            if (number == random)
            {
                Console.WriteLine($"You guess it! You made in {guess} guesses!");
                Console.Write("Would you like to play again? ");
                answer = Console.ReadLine();
            }

        } while (answer == "yes");
        
    }
}