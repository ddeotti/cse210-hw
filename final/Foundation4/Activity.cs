public abstract class Activity
{
    private DateTime date;
    private int minutes;

    public Activity(DateTime date, int minutes)
    {
        SetDate(date);
        SetMinutes(minutes);
    }

    protected DateTime GetDate()
    {
        return date;
    }

    private void SetDate(DateTime value)
    {
        date = value;
    }

    protected int GetMinutes()
    {
        return minutes;
    }

    private void SetMinutes(int value)
    {
        minutes = value;
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