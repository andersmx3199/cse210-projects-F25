class SwimmingActivity : Activity
{
    private double _lapNums = 0;

    public SwimmingActivity(string date, int duration, string activity, double lapNums) : base (date, duration, activity)
    {
        _lapNums = lapNums;
    }

    public override double GetDistance()
    {
        return Math.Round((((_lapNums * 50) / 1000) * 0.62),2);
    }

    public override double GetSpeed()
    {
        return Math.Round(((GetDistance() / _duration) * 60),2);
    }

    public override double GetPace()
    {
        return Math.Round((_duration / GetDistance()),1);
    }
}