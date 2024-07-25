public class Menu
{
    private GoalManager _goalManager;

    public Menu(GoalManager goalManager)
    {
        _goalManager = goalManager;
    }

    public void Display()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Mark a Goal as Done");
            Console.WriteLine("7. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    _goalManager.CreateGoal();
                    Console.ReadKey();
                    break;
                case "2":
                    _goalManager.ListGoalNames();
                    Console.ReadKey();
                    break;
                case "3":
                    _goalManager.ListGoalDetails();
                    Console.ReadKey();
                    break;
                case "4":
                    _goalManager.SaveGoals();
                    Console.ReadKey();
                    break;
                case "5":
                    _goalManager.LoadGoals();
                    Console.ReadKey();
                    break;
                case "6":
                    _goalManager.RecordEvent();
                    Console.ReadKey();
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
