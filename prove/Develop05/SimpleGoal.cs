public class SimpleGoal : Goal
{
    private bool _IsComplete;

    public SimpleGoal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
 
    }


    public void RecordEvent()
    {

    }

    public bool IsComplete()
    {
        return true;
    }

    public string GetStringRepresentation()
    {
        return "string";
    }
}