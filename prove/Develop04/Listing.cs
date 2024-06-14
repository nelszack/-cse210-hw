using System;
public class Listing:Base{
    private List<string> _prompt=["Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"];
    private List<string> _responce=[];

    public Listing(string Message,string Activity="listing"):base(Message,Activity){
        
    }

    public void DisplayActivity(){
        Random Index= new Random();
        int RandIndex=Index.Next(_prompt.Count());
        string prompt=_prompt[RandIndex];
        Console.WriteLine($"List as many responces you can from the following promt\n{prompt}");
        StartTimer(5);
        Console.WriteLine("You may begin");
        DateTime StartTime=DateTime.Now;
        DateTime EndTime=StartTime.AddSeconds(_seconds);
        while(DateTime.Now<EndTime){
        Console.Write('>');
        _responce.Add(Console.ReadLine());
        } 
        Console.WriteLine($"You listed {_responce.Count()} times");
    }

}