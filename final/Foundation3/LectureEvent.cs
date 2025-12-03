using System.Runtime.CompilerServices;

class LectureEvent : Event
{
    private int _capacity = 0;
    private string _speaker = "";

    // Lecture event is using inheritance from the event class.
    public LectureEvent(string title, string description, DateTime date, string time, Address address, string speaker, int capacity, string eventType) : base(title, description, date, time, address, eventType)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFull()
    {
        return ($"{GetStandard}\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}");
    }
}