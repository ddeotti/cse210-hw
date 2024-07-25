public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Goal '{ShortName}' completed! You earned {Points} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{ShortName}' is already completed.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"{ShortName}: {Description} - {(_isComplete ? "Completed" : "Not Completed")}";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{ShortName},{Description},{Points},{_isComplete}";
    }
}
