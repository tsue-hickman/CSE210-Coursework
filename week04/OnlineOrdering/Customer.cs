
using System;

public class Customer
{
    // Private member variables (encapsulation)
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to check if customer lives in USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Getters and setters
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Address Address
    {
        get { return _address; }
        set { _address = value; }
    }
}