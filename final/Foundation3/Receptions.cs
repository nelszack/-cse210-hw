using System;
public class Receptions:Event {
    private string _rsvp;


    public Receptions(string Title ,string Desc,string Date,string Time,string Address,string RSVP,string Type="Reception"):base(Title,Desc,Date,Time,Address,Type) {
        _rsvp=RSVP;
    }
    public void DisplayFull() {
        Console.WriteLine($"title:{_eventTitle}\ndesctiption:{_description}\ndate:{_date}\ntime:{_time}\naddress:{_address}\nrsvp at:{_rsvp}");
    }
}