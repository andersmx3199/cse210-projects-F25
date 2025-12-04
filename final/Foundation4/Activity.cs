using System.Diagnostics.Contracts;

abstract class Activity
{
    // Had an issue with these being private. Asked AI for help. Suggested to turn to protected instead.
    protected string _date;
    protected int _duration;
    protected string _activity = "";

    public Activity(string date, int duration, string activity)
    {
        _date = date;
        _duration = duration;
        _activity = activity;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return ($"{_date} {_activity} ({_duration}mins) -  Distance {GetDistance():0.00} miles, Speed {GetSpeed():0.00} mph, Pace {GetPace():0.00} min per mile");
    }
}