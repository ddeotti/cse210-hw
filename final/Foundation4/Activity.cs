public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        SetDate(date);
        SetMinutes(minutes);
    }

    protected DateTime GetDate()
    {
        return _date;
    }

    private void SetDate(DateTime value)
    {
        _date = value;
    }

    protected int GetMinutes()
    {
        return _minutes;
    }

    private void SetMinutes(int value)
    {
        _minutes = value;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} {GetType().Name} ({GetMinutes()} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
