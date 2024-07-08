using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lecture = new("Become better", "learn how to become better", "sept 30 2030", "12:30 pm", "teton event center", "john smith", 200);
        lecture.DisplayShort();
        Console.WriteLine();
        lecture.DisplayStandard();
        Console.WriteLine();
        lecture.DisplayFull();
        Console.WriteLine();
        Receptions reception = new("Become better2", "learn how to become better", "sept 30 2030", "12:30 pm", "teton event center", "rsvp@event.com");
        reception.DisplayShort();
        Console.WriteLine();
        reception.DisplayStandard();
        Console.WriteLine();
        reception.DisplayFull();
        Console.WriteLine();
        Outdoor outdoor = new("Become better3", "learn how to become better", "sept 30 2030", "12:30 pm", "teton event center", "cloudy with a chance of meatballs");
        outdoor.DisplayShort();
        Console.WriteLine();
        outdoor.DisplayStandard();
        Console.WriteLine();
        outdoor.DisplayFull();
        Console.WriteLine();
    }
}