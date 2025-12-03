class RunningActivity : Activity
{
    private double _distance = 0;

    public RunningActivity(string date, int duration, string activity, double distance) : base (date, duration, activity)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return Math.Round((_distance),2);
    }

    public override double GetSpeed()
    {
        return Math.Round(((_distance / _duration) * 60),2);
    }

    public override double GetPace()
    {
        return Math.Round((_duration / _distance), 2);
    }
}