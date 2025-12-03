using System.ComponentModel;

abstract class Event
{
    // Attributes for the Base Event Class
    private string _title = "";
    private string _description = "";
    private string _date;
    private string _time = "";
    private Address _address;
    private string _eventType = "";

    // Behaviors for the Base Event Class
    // Event constructor
    public Event(string title, string description, string date, string time, Address address, string eventType)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }

    // Get the standard description
    public string GetStandard()
    {
        return ($"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nLocation: {_address.GetAddress()}");
    }

    // Get the full description. NEED TO ADD THE TYPE OF EVENT!
    public abstract string GetFull();

    // Get the short description.
    public string GetShort()
    {
        return ($"Event Type: {_eventType}\nTitle: {_title}\nDate: {_date}");
    }
}