public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        SetLaps(laps);
    }

    private int GetLaps()
    {
        return laps;
    }

    private void SetLaps(int value)
    {
        laps = value;
    }

    public override double GetDistance()
    {
        return GetLaps() * 50 / 1000.0 * 0.62; // Convert to miles
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
