/* 
    To exceed the requirements I added a check on the menu, to avoid bugs.
    I also added a Prompt class to make the program more clean
    I added one more item on the menu to show simple statistics
*/
using System;
class Program
{
    static void Main(string[] args)
    {
        Prompts appPrompts = new Prompts();
        int countListing = 0;
        int countBreathing = 0;
        int countReflecting = 0;
        int countTotalDuration = 0;

        bool menuRun = true;
        while (menuRun)
        {
            Console.Clear();
            int option = -1;
            Console.WriteLine("===== Mindfulness Program =====");
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. List the usage data");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");
            if (int.TryParse(Console.ReadLine(), out option))
            {
                switch (option)
                {
                    case 1:

                        BreathingActivity breathing = new BreathingActivity("breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                        breathing.Start();
                        countBreathing++;
                        countTotalDuration += breathing.Duration;
                        break;
                    case 2:
                        ReflectionActivity reflecting = new ReflectionActivity("reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", appPrompts.reflectionPrompts, appPrompts.reflectionQuestions);
                        reflecting.Run();
                        countReflecting++;
                        break;
                    case 3:
                        ListingActivity listing = new ListingActivity("listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", appPrompts.listingPrompts);
                        listing.Run();
                        countListing++;
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("===== Data usage report =====");
                        Console.WriteLine($"You accessed the breathing activity {countBreathing} times");
                        Console.WriteLine($"You accessed the reflection activity {countReflecting} times");
                        Console.WriteLine($"You accessed the listing activity {countListing} times");
                        Console.WriteLine($"You have made a total of {countTotalDuration} seconds in activities");
                        Thread.Sleep(5000);
                        break;
                    case 5:
                        menuRun = false;
                        Console.Clear();
                        Console.WriteLine("I hope you have enjoyed the Mindfulness aplication.");
                        Console.WriteLine("See you later.");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}