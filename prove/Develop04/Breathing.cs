using System;

public class Breathing:Base{
    

    public Breathing(string message,string activity="breathing"):base(message,activity){

    }
    
    public void displayActivity(){
        Console.WriteLine("Get ready ");
        StartTimer(5);
        DateTime startTime=DateTime.Now;
        DateTime endtime=startTime.AddSeconds(_seconds);
        int i=0;
        while(DateTime.Now<endtime){
            Console.WriteLine("Breath in ...");
            StartTimer(5);
            Console.WriteLine("Breath out ...");
            StartTimer(5);
            i++;
            string[] timerList=_timerList;
            if (i>=timerList.Count()){
            i=0;
            }
        }
        

    }
    
}