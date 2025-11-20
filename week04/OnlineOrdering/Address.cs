public class Address    // Address attributes
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country) // Address constructor
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()    //  Determine whether "usa" is the address, returns true regardless of case type (To lower)
    {
        return _country.ToLower() == "usa";
    }

    public string GetFullAddress()     // Method to display the address
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}
