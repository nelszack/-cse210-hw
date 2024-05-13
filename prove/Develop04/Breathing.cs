using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public class Breathing:Base{
    

    public Breathing(){

    }
    public int displayOPening(){
        Console.WriteLine("Welcome to the Breathing activity.\nThis activity will help you relax by walking you through breathing in and out slowly. clear your mind and focus on your breathing.");
        Console.Write("how long do you want the activity to be ");
        string activityTimestr=Console.ReadLine();
        int activityTime= int.Parse(activityTimestr);
        return activityTime;
    }
    public void displayActivity(int time){
        Console.WriteLine("Get ready ");
        StartTimer(5,_timerList);
        DateTime startTime=DateTime.Now;
        DateTime endtime=startTime.AddSeconds(time);
        int i=0;
        while(DateTime.Now<endtime){
            Console.WriteLine("Breath in ...");
            StartTimer(5,_timerList);
            Console.WriteLine("Breath out ...");
            StartTimer(5,_timerList);
            i++;
            string[] timerList=_timerList;
            if (i>=timerList.Count()){
            i=0;
            }
        }

    }
    
}