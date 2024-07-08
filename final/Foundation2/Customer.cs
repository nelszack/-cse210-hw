using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer()
    {

    }
    public bool IsUS()
    {
        return _address.GetUS();
    }

    public Address GetAddress()
    {
        return _address;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetAddress(Address address)
    {
        _address = address;
    }
    public void SetName(string name)
    {
        _name = name;
    }

}