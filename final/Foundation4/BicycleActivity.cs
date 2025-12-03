class BicycleActivity : Activity
{
    private double _speed = 0;

    public BicycleActivity(DateTime date, int duration, string activity, double speed) : base (date, duration, activity)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * _duration);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}