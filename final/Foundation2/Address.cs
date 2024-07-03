using System;

public class Address {
    private string _streetAdress;
    private string _city;
    private string _state;
    private string _country;
    private bool _native;

    public Address(string Street,string City,string State,string Country,bool Native=true){
        _streetAdress=Street;
        _city=City;
        _state=State;
        _country=Country;
        _native=Native;
    }

    public bool GetNative() {
        return _native;
    }
    public string GetCountry() {
        return _country;
    }
    public string GetCity() {
        return _city;
    }
    public string GetState() {
        return _state;
    }
    public string GetStreet() {
        return _streetAdress;
    }
    public string MakeString() {
        return $"{_streetAdress}, {_city}, {_state}, {_country}";
    }
}