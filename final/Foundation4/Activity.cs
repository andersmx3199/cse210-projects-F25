using System.Diagnostics.Contracts;

abstract class Activity
{
    private DateTime _date;
    private int _duration = 0;
    private string _activity = "";

    public Activity(DateTime date, int duration, string activity)
    {
        _date = date;
        _duration = duration;
        _activity = activity;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetDateAndDuration()
    {
        return ($"{_date} {_activity} ({_duration}) - ");
    }

}