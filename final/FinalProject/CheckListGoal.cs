   public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            int earnedPoints = Points;
            if (_amountCompleted == _target)
            {
                earnedPoints += _bonus; // Bônus ao completar todos os passos
                Console.WriteLine($"Congratulations! You have completed the goal '{ShortName}' and earned an extra bonus of {_bonus} points!");
            }
            Console.WriteLine($"Event recorded for checklist goal '{ShortName}'. You earned {earnedPoints} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{ShortName}' is already completed.");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{ShortName}: {Description} - Completed {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{ShortName},{Description},{Points},{_target},{_bonus},{_amountCompleted}";
    }
}
 