using System;
public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string Title, string Desc, string Date, string Time, string Address, string Weather, string Type = "Outdoor") : base(Title, Desc, Date, Time, Address, Type)
    {
        _weather = Weather;
    }

    public void DisplayFull()
    {
        Console.WriteLine("full detail:");
        Console.WriteLine($"title:{_eventTitle}\ndesctiption:{_description}\ndate:{_date}\ntime:{_time}\naddress:{_address}\nweather forcast:{_weather}");
    }


}