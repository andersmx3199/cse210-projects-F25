using System;

abstract class Goals
{
    protected string _title;
    protected int _points;
    protected bool _isComplete;

    protected Goals(string title, int points)
    {
        _title = title;
        _points = points;
        _isComplete = false;
    }

    public void SetComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public virtual int RecordEvent()
    {
        if (_isComplete) return 0;
        _isComplete = true;
        return _points;
    }

    public virtual string GetStatus()
    {
        string checkbox;

        if (_isComplete)
            checkbox = "[X]";
        else
            checkbox = "[ ]";

        return $"{checkbox} {_title}";
    }
}
