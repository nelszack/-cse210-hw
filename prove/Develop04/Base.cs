using System;


public class Base{
    protected string[]_timerList=["|","/","-","\\"];
    protected int _seconds;
    protected string _message;
    protected string _activity;

    
    public Base(){

    }
    public Base(string Message,string Activity){
        _message=Message;
        _activity=Activity;
    }

    public static string DisplayMenu(){
        Console.Write("1. Start Breathing Activity\n2. Start reflection activity\n3. Start listing activity\n4. Display the number of times compleated for each activity\n5. Quit\nwhat do you chose:");
        string Choise=Console.ReadLine();
        return Choise;
    }

    public void DisplayOpening(){
        Console.WriteLine(_message);
        Console.Write("How long do you want the activity to be ");
        string ActivityTimeStr=Console.ReadLine();
        int activityTime= int.Parse(ActivityTimeStr);
        _seconds=activityTime;
    }

    public void StartTimer(int Time){
        DateTime StartTime= DateTime.Now;
        DateTime EndTime= StartTime.AddSeconds(Time);
        int i=0;
        while(DateTime.Now<EndTime){
            string s=_timerList[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i>=_timerList.Count()){
            i=0;
            }

        }
    
    }
    public void ClosingMessage(){
        Console.WriteLine("\nWell done");
        Console.WriteLine($"You completed another {_seconds} seconds of the {_activity} activity");
    }
    
}