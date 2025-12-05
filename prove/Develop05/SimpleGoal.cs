class SimpleGoal : Goal
{
    public SimpleGoal(string title, int points) : base(title, points) { }

    public override int RecordEvent()
    {
        // award only once
        return base.RecordEvent();
    }

}
