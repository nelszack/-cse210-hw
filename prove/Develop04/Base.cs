using System;

public class Base{
    protected string[]_timerList=["|","/","-","\\"];
    private int _seconds;
    
    public Base(){

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

    public void StartTimer(int seconds,string[] timerList){
        DateTime starttime= DateTime.Now;
        DateTime endtime= starttime.AddSeconds(seconds);
        int i=0;
        while(DateTime.Now<endtime){
            string s=timerList[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i>=timerList.Count()){
            i=0;
            }

        }
    }

    
}