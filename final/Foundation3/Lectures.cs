using System;
public class Lectures:Event {
    private string _speaker;
    private int _capacity;

    public Lectures(string Title ,string Desc,string Date,string Time,string Address,string Speaker, int Capacity,string Type="Lecture"):base(Title,Desc,Date,Time,Address,Type) {
        _speaker=Speaker;
        _capacity=Capacity;
    }

    public void DisplayFull() {
        Console.WriteLine("full detail:");
        Console.WriteLine($"title: {_eventTitle}\ndescription: {_description}\ndate:{_date}\ntime:{_time}\naddress:{_address}\nspeaker:{_speaker}\ncapacity:{_capacity}");
    }
    
}