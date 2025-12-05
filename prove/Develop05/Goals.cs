using System;

abstract class Goal
{
    protected string _title;
    protected int _points;
    protected bool _completed;

    protected Goal(string title, int points)
    {
        _title = title ?? "";
        _points = points;
        _completed = false;
    }

    public void SetComplete(bool complete) => _completed = complete;

    /// Called when the player records progress for this goal.
    /// Returns the number of points awarded by this event.
    public virtual int RecordEvent()
    {
        if (_completed) return 0;
        _completed = true;
        return _points;
    }

    public virtual string GetStatus()
    {
        return $"{(_completed ? "[X]" : "[ ]")} {_title}";
    }

    /// Return a single-line representation for saving.
    /// Subclasses should override to add additional fields.

}
