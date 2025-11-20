public class Customer  // Customer attribute and the Address object
{
    private string _name;
    private Address _address;  

    public Customer(string name, Address address) // Our Customer constructor
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA() 
    {
        return _address.IsInUSA();
    }

    public string GetName() // Getter to help us access our private _name variable
    {
        return _name;
    }

    public string GetAddressString()  // Accessing our Address object method
    {
        return _address.GetFullAddress();
    }
}
