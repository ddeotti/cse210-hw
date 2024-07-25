public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        SetLaps(laps);
    }

    private int GetLaps()
    {
        return _laps;
    }

    private void SetLaps(int value)
    {
        _laps = value;
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
