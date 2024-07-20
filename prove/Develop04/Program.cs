using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int option = -1;
        bool menuRun = true;
        while (menuRun)
        {
            Console.WriteLine("===== Mindfulness program =====");
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = -1;
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                    string name = "breathing";

                    BreathingActivity breathing = new BreathingActivity(name, description, 10);
                    breathing.DisplayStartingMessage();
                    breathing.DisplayEndingMessage();
                    //breathing.ShowSpinner(5);
                    breathing.ShowCountDown(5);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    menuRun = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

        }
    }
}