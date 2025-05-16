using System;

public class Address
{
    // Private member variables (encapsulation)
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    // Constructor
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // Method to check if address is in USA
    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA" || _country.ToUpper() == "UNITED STATES" ||
               _country.ToUpper() == "UNITED STATES OF AMERICA";
    }

    // Method to get the full address as a string
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }

    // Getters and setters
    public string StreetAddress
    {
        get { return _streetAddress; }
        set { _streetAddress = value; }
    }

    public string City
    {
        get { return _city; }
        set { _city = value; }
    }

    public string StateProvince
    {
        get { return _stateProvince; }
        set { _stateProvince = value; }
    }

    public string Country
    {
        get { return _country; }
        set { _country = value; }
    }
}