using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string waitKbd = "";


        ScriptureGenerator baseScripture = new ScriptureGenerator();
        Reference reference = baseScripture.refGenerator();
        Scripture scripture = new Scripture(reference, baseScripture.txtGenerator()); 


        while (true)
        {
            Console.Clear(); // Clear the console screen
            Console.WriteLine("========== Scripture memorizer ==========");
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press ENTER do continue or type 'quit' to finish: ");
            Console.Write("> ");
            waitKbd = Console.ReadLine();

            if (waitKbd == "quit" || scripture.IsCompletelyHidden())
            {
                break;
            }
            scripture.HideRandomWords(scripture.rndIndexHideWord());

        }
    }
}