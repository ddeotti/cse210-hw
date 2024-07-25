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
            _goalManager.DisplayPlayerInfo();
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
                    Console.Clear();
                    _goalManager.CreateGoal();
                    Spinner.ShowSpinner(5); 
                    break;
                case "2":
                    Console.Clear();
                    _goalManager.ListGoalNames();
                    Spinner.ShowSpinner(5); 
                    break;
                case "3":
                    Console.Clear();
                    _goalManager.ListGoalDetails();
                    Spinner.ShowSpinner(5); 
                    break;
                case "4":
                    Console.Clear();
                    _goalManager.SaveGoals();
                    Spinner.ShowSpinner(5); 
                    break;
                case "5":
                    Console.Clear();
                    _goalManager.LoadGoals();
                    Spinner.ShowSpinner(5); 
                    break;
                case "6":
                    Console.Clear();
                    Console.WriteLine("Goals list:");
                    _goalManager.ListGoalNames();
                    _goalManager.RecordEvent();
                    Spinner.ShowSpinner(5); 
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Spinner.ShowSpinner(5); 
                    break;
            }
        }
    }
}
