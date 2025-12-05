class CheckGoal : Goals
{
    private int _target;
    private int _current;
    private int _bonus;

    public CheckGoal(string title, int points, int target, int bonus) : base(title, points)
    {
        _target = target;
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
        if (_current >= _target)
        {
            _completed = true;
            return _points + _bonus;
        }

        return _points;
    }

    public override string GetStatus()
    {
        return $"{GetStatus()} (Completed {_current}/{_target})";
    }

}
