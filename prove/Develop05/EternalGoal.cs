class EternalGoal : Goal
{
    public EternalGoal(string title, int points) : base(title, points) { }

    // Eternal goals never mark complete; they always award points
    public override int RecordEvent()
    {
        return _points;
    }

}
