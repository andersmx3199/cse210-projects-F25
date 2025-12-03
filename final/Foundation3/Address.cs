class Address
{
    // Attributes for Address Class
    private string _houseStreet = "";
    private string _city = "";
    private string _state = "";
    private string _country = "";

    // Behaviors for Address Class
    public Address(string houseStreet, string city, string state, string country)
    {
        _houseStreet = houseStreet;
        _city = city;
        _state = state;
        _country = country;
    }

    // May not need the USA method from Foundation2
    // public bool InUSA()
    // {
    //     return _country.ToLower() == "usa";
    // }

    public string GetAddress()
    {
        return ($"{_houseStreet}\n{_city}, {_state}\n{_country}");
    }
}