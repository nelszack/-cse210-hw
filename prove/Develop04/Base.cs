using System;


public class Base{
    protected string[]_timerList=["|","/","-","\\"];
    protected int _seconds;
    protected string _message;
    protected string _activity;

    
    public Base(){

    }
    public Base(string message,string activity){
        _message=message;
        _activity=activity;
    }

    public static string DisplayMenu(){
        Console.Write("1. Start Breathing Activity\n2. Start reflection activity\n3. Start listing activity\n4. Display the number of times compleated for each activity\n5. Quit\nwhat do you chose:");
        string choise=Console.ReadLine();
        return choise;
    }

    public void DisplayOpening(){
        Console.WriteLine(_message);
        Console.Write("How long do you want the activity to be ");
        string activityTimestr=Console.ReadLine();
        int activityTime= int.Parse(activityTimestr);
        _seconds=activityTime;
    }

    public void StartTimer(int time){
        DateTime starttime= DateTime.Now;
        DateTime endtime= starttime.AddSeconds(time);
        int i=0;
        while(DateTime.Now<endtime){
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
        Console.WriteLine("well done");
        Console.WriteLine($"you completed another {_seconds} seconds of the {_activity} activity");
    }
    
}