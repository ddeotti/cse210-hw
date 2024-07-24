public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        SetDistance(distance);
    }

     private void SetDistance(double value)
    {
        distance = value;
    }

    public override double GetDistance()
    {
        return distance; // Return the distance directly
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}