/*
 My attempt to exceed the requirements
 was to format the output of the Journal entries 
 on the Display() method of Entry Class.

 Besides this, I cleared the screen and show
 a message of "Press any key to continue" on
 itens 2 to 4


*/


using System;
using System.IO; 
using System.Collections.Generic;

class Program
{   

    static void Main(string[] args)
    {
        bool running = true;
        PromptGenerator generator = new PromptGenerator(); // Prompt generator
        Journal inputJournal = new Journal(); // Input entry to the Journal
        string fileName;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Load from a file");
            Console.WriteLine("4. Save to a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string actualPrompt = generator.GetRandomPrompt();
                    Console.WriteLine("");
                    Console.WriteLine("Enter some text to write: ");
                    Console.WriteLine("");
                    Console.WriteLine(actualPrompt);
                    Console.Write("> ");
                    string inputText = Console.ReadLine();
                    string dateTimeStamp = DateTime.Now.ToString("F");
                    inputJournal.AddEntry(dateTimeStamp, actualPrompt, inputText);
                    break;
                case "2":
                    Console.WriteLine("Entries:");
                    inputJournal.DisplayAll();
                    WaitKeyPress();
                    break;
                case "3":
                    Console.WriteLine("");
                    Console.Write("Write the filename to load: ");
                    fileName = Console.ReadLine();
                    inputJournal.LoadFromFile(fileName);
                    WaitKeyPress();
                    break;
                case "4":
                    Console.WriteLine("");
                    Console.Write("Write the file name and its extension: ");
                    fileName = Console.ReadLine();
                    inputJournal.SaveToFile(fileName);
                    WaitKeyPress();
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Bye bye, have a nice day!");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    WaitKeyPress();
                    break;
            }

            Console.WriteLine();
        }
    }
    static void WaitKeyPress() 
    {
        Console.WriteLine("");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
