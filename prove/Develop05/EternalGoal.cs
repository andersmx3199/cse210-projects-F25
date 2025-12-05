class EternalGoal : Goals
{
    public EternalGoal(string title, int points) : base(title, points) { }

    // Eternal goals never mark complete but always award points
    public override int RecordEvent()
    {
        return _points;
    }

}
