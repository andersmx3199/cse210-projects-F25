using System.Runtime.CompilerServices;

class ReceptionEvent : Event
{
    private string _RSVP = "";

    // Lecture event is using inheritance from the event class.
    public ReceptionEvent(string title, string description, DateTime date, string time, Address address, string RSVP, string eventType) : base(title, description, date, time, address, eventType)
    {
        _RSVP = RSVP;
    }

    public override string GetFull()
    {
        return ($"{GetStandard}\nType: Reception Event\nRSVP: {_RSVP}");
    }
}