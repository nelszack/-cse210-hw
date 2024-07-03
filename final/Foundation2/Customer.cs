using System;

public class Customer {
    private string _name;
    private Address _adress;

    public Customer() {

    }
    public bool IsNative() {
        return _adress.GetNative();
    }

    public Address GetAddress() {
        return _adress;
    }
    public string GetName() {
        return _name;
    }
    public void SetAddress(Address address) {
         _adress=address;
    }
    public void SetName(string name) {
        _name=name;
    }

}