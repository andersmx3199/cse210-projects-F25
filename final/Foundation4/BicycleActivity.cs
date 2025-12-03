class BicycleActivity : Activity
{
    private double _speed = 0;

    public BicycleActivity(string date, int duration, string activity, double speed) : base (date, duration, activity)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return Math.Round(((_speed * _duration) / 60),2);
    }

    public override double GetSpeed()
    {
        return Math.Round((_speed),2);
    }

    public override double GetPace()
    {
        return Math.Round((60 / _speed),2);
    }
}