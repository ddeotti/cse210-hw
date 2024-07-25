public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private Menu _menu;

    public GoalManager()
    {
        _menu = new Menu(this);
    }

    public void Start()
    {
        _menu.Display();
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Total Score: {_score}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            var goal = _goals[i];
            string status = goal.IsComplete() ? "[ X ]" : "[ ]";
            Console.WriteLine($"{i + 1}. {goal.ShortName} {status}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            var goal = _goals[i];
            string status = goal.IsComplete() ? "[ X ]" : "[ ]";
            Console.WriteLine($"{i + 1}. {goal.GetDetailsString()} {status}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goal are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal?: ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("What is the amount of points associated with this goal? ");
                int bonus = int.Parse(Console.ReadLine());

                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice. Goal not created.");
                break;
        }
    }

    public void RecordEvent()
    {
        Console.Write("Enter goal name to record event: ");
        string goalName = Console.ReadLine();

        foreach (var goal in _goals)
        {
            if (goal.ShortName == goalName)
            {
                goal.RecordEvent();
                _score += goal.Points;
                return;
            }
        }
        Console.WriteLine("Goal not found.");
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save goals: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Data saved.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load goals: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        foreach (string line in lines[1..])
        {
            string[] parts = line.Split(",");
            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            switch (goalType)
            {
                case "SimpleGoal":
                    bool isComplete = bool.Parse(parts[4]);
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    if (isComplete) simpleGoal.RecordEvent();
                    _goals.Add(simpleGoal);
                    break;
                case "EternalGoal":
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                    break;
                case "ChecklistGoal":
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    int amountCompleted = int.Parse(parts[6]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    for (int i = 0; i < amountCompleted; i++) checklistGoal.RecordEvent();
                    _goals.Add(checklistGoal);
                    break;
            }
        }
        Console.WriteLine("Data loaded.");
    }
}
 