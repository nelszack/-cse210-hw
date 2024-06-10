using System;
public class Listing:Base{
    private List<string> _prompt=["Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"];
    private List<string> _responce=[];

    public Listing(string message): base(message){
        
    }

    public void DisplayActivity(){
        Random index= new Random();
        int RandIndex=index.Next(_prompt.Count());
        string prompt=_prompt[RandIndex];
        Console.WriteLine($"list as many responces you can from the following promt\n{prompt}");
        StartTimer(5);
        Console.WriteLine("you may begin");
        DateTime startTime=DateTime.Now;
        DateTime endtime=startTime.AddSeconds(_seconds);
        while(DateTime.Now<endtime){
        Console.Write('>');
        _responce.Add(Console.ReadLine());
        } 
        
        
        Console.WriteLine($"you listed {_responce.Count()} times");
    }

}