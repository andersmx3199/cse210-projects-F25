using System.ComponentModel;

class Event
{
    // Attributes for the Base Event Class
    private string _title = "";
    private string _description = "";
    private DateTime _date;
    private string _time = "";
    private Address _address;

    // Behaviors for the Base Event Class
    // Event constructor
    public Event(string title, string description, DateTime date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
}