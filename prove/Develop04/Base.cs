using System;

public class Base{
    private string[] _timerList=["|","/","-","\\"];
    // private
    // private
    // private

    public Base(){

    }

    public string DisplayMenu(){

        Console.WriteLine("Menu Options:\n1. Start breathing activity\n2. Start reflection activity\n3. Start listing activity\n4. Quit");
        Console.Write("Select one of the options from the menu ");
        string Choice=Console.ReadLine();
        return Choice;
    }

    public void Timer(int Seconds){
        DateTime StartTime=DateTime.Now;
        DateTime EndTime=StartTime.AddSeconds(Seconds);
        int i=0;
        while(DateTime.Now<EndTime){
            Console.Write(_timerList[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i>=_timerList.Count()){
                i%=_timerList.Count();
            }
        }


    }

}