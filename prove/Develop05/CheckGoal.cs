class CheckGoal : Goals
{
    private int _accomplished;
    private int _current;
    private int _bonus;

    public CheckGoal(string title, int points, int accomplished, int bonus) : base(title, points)
    {
        _accomplished = accomplished;
        _current = 0;
        _bonus = bonus;
    }

    public void SetCurrentCount(int count)
    {
        _current = count;
    }

    public override int RecordEvent()
    {
        if (_completed) return 0;

        _current++;
        if (_current >= _accomplished)
        {
            _completed = true;
            return _points + _bonus;
        }

        return _points;
    }

    public override string GetStatus()
    {
        string checkbox;

        if (_completed)
            checkbox = "[X]";
        else
            checkbox = "[ ]";

        string baseStatus = $"{checkbox} {_title}";
        return $"{baseStatus} (Completed {_current}/{_accomplished})";
    }
}
