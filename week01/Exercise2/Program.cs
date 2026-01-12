using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
        string letter = "";
        string sign = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "C";
        }
        else if (percentage < 60)
        {
            letter = "F";
        }

        int remainder = percentage % 10;
        
        if (remainder >=7)
        {
            sign = "+";
        }
        else if (remainder <= 3)
        {
            sign = "-";
        }

        if (letter == "A")
        {
            if (sign == "+")
            {
            sign = "";
            }
        }
        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (percentage >= 70)
        {
            Console.WriteLine("You passed! Congratulations!");
        }
        else
        {
            Console.WriteLine("Don't give up! You can do it!");
        }
    }
}