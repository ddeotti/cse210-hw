public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Event recorded for eternal goal '{ShortName}'. You earned {Points} points.");
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetDetailsString()
    {
        return $"{ShortName}: {Description} - Ongoing";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{ShortName},{Description},{Points}";
    }
}
