using System.Runtime.CompilerServices;

class OutdoorEvent : Event
{
    private string _weather = "";

    // Lecture event is using inheritance from the event class.
    public OutdoorEvent(string title, string description, DateTime date, string time, Address address, string weather, string eventType) : base(title, description, date, time, address, eventType)
    {
        _weather = weather;
    }

    public override string GetFull()
    {
        return ($"{GetStandard}\nType: Outdoor Event\nWeather: {_weather}");
    }
}