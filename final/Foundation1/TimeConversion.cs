public class TimeConversion
{
    private int _seconds;
    public TimeConversion(int seconds)
    {
        _seconds = seconds;
    }

    public int Hours()
    {
        int hours = _seconds / 3600;
        _seconds = _seconds - hours * 3600;
        return hours;    
    }

    public int Minutes()
    {
        int minutes = _seconds / 60;
        _seconds = _seconds - minutes * 60;
        return minutes;
    }

    public int Seconds()
    {
        return _seconds;
    } 
}
