using System;
class Program
{
    static void Main(string[] args)
    {
        bool menuRun = true;
        while (menuRun)
        {
            Console.Clear();
            int option = -1;
            Console.WriteLine("===== Mindfulness Program =====");
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create a new goal"); 
            Console.WriteLine("2. List goals"); 
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals"); 
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            if (int.TryParse(Console.ReadLine(), out option))
            {
                switch (option)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        menuRun = false;
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