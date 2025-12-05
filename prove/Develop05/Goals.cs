using System;

abstract class Goals
{
    protected string _title;
    protected int _points;
    protected bool _completed;

    protected Goals(string title, int points)
    {
        _title = title;
        _points = points;
        _completed = false;
    }

    public void SetComplete(bool complete) => _completed = complete;

    public abstract int RecordEvent();

    public virtual string GetStatus()
    {
        return $"{(_completed ? "[X]" : "[ ]")} {_title}";
    }
}
