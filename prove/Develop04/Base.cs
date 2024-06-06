using System;

public class Base{
    protected string[]_timerList=["|","/","-","\\"];
    protected int _seconds;
    protected string _message;
    
    public Base(){

    }
    public Base(string message){
        _message=message;
    }
    public Base(int seconds){
        _seconds=seconds;
        
    }

    public string DisplayMenu(){
        Console.Write("1. Start Breathing Activity\n2. Start reflection activity\n3. Start listing activity\n4. Quit\nwhat do you chose:");
        string choise=Console.ReadLine();
        return choise;
    }
    public string[] GetTimerList(){
        string[] timeList= _timerList;
        return timeList;
    }

    public void displayOPening(){
        Console.WriteLine(_message);
        Console.Write("how long do you want the activity to be ");
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

    
}