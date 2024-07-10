using System;
public class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _type;



    public Event(string Title, string Desc, string date, string Time, string Address, string Type)
    {
        _eventTitle = Title;
        _description = Desc;
        _date = date;
        _time = Time;
        _address = Address;
        _type = Type;
    }

    public void DisplayStandard()
    {
        Console.WriteLine("standard detail:");
        Console.WriteLine($"title:{_eventTitle}\ndescrition:{_description}\ndate:{_date}\ntime:{_time}\naddress:{_address}");
    }

    public void DisplayShort()
    {
        Console.WriteLine("short detail:");
        Console.WriteLine($"type:{_type}\ntitle:{_eventTitle}\ndate:{_date}");
    }
}