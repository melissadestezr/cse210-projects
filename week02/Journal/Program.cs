using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {   
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        Console.WriteLine("Welcome to the Journal Program!");
        bool run = true;
        while (run)
        {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Exit");
        Console.Write("What would you like to do? ");
        string input = Console.ReadLine();

        if (input == "1")
            {
                string promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine(promptText);
                string entryText = Console.ReadLine();
                Entry entry = new Entry(promptText, entryText);
                journal.AddEntry(entry);
            }
        else if (input == "2")
            {
                journal.DisplayAll();
            }
        else if (input == "3")
            {
                Console.WriteLine("Loading....");
                journal.LoadFromFile("myJournal.txt");
                journal.DisplayAll();
            }
        else if (input == "4")
            {   
                Console.WriteLine("Saving...");
                journal.SaveToFile("myJournal.txt");
                Console.WriteLine("Saved successfully!");
            }
        else if (input == "5")
            {
                Console.WriteLine("See you next time!");
                run = false;
            }
        }
    }
}