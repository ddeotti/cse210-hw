public class CheckListGoal : Goal
{
    int _amountCompleted;
    int _target;
    int _bonus;

    public CheckListGoal(string name, string description, string points, int target, int bonus) : base(name,description,points)
    {

    }

    public void RecordEvent()
    {

    }

    public bool IsComplete()
    {
        return true;
    }

    public string GetDetailsString()
    {
        return "string";
    }

    public string GetStringRepresentation()
    {
        return "string";
    }
}