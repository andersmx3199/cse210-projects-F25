class RunningActivity : Activity
{
    private double _distance = 0;

    public RunningActivity(DateTime date, int duration, string activity, double distance) : base (date, duration, activity)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _duration) * 60;
    }

    public override double GetPace()
    {
        return (_duration / _distance);
    }
}