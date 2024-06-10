using System;
public class Listing:Base{
    private List<string> _prompt=["this is fun"];
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