using System.Reflection.Metadata.Ecma335;

class Customer
{
    // Attributes for Customer Class
    private string _name = "";
    private Address _address;
    private bool USA;

    // Behaviors for Customer Class
    public Customer(string name, Address address, bool usa)
    {
        _name = name;
        _address = address;
        USA = usa;
    }

    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public bool GetUSA()
    {
        return USA;
    }
}