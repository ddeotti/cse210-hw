public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        SetSpeed(speed);
    }

    private void SetSpeed(double value)
    {
        _speed = value;
    }

    public override double GetDistance()
    {
        return (GetSpeed() * GetMinutes()) / 60;
    }

    public override double GetSpeed()
    {
        return _speed; // Return the speed directly
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}
