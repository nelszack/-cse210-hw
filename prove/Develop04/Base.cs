using System;


public class Base{
    protected string[]_timerList=["|","/","-","\\"];
    protected int _seconds;
    protected string _message;
    protected string _activity;
    private int _breathingCount=0;
    private int _reflectionCount=0;
    private int _listingCount=0;

    
    public Base(){

    }
    public Base(string Message,string Activity){
        _message=Message;
        _activity=Activity;
       
    }

    public string DisplayMenu(){
        Console.Write("1. Start Breathing Activity\n2. Start reflection activity\n3. Start listing activity\n4. Display the number of times compleated for each activity\n5. Quit\nwhat do you chose:");
        string Choise=Console.ReadLine();
        return Choise;
    }
    public int GetCount(string Activity){
        switch (Activity)
        {
            case "breathing":
                return _breathingCount;
            case "reflection":
                return _reflectionCount;
            case "listing":
                return _listingCount;
            default:
                return 0;

                
        }
    

    }
    public void SetCount(string Activity,int numb=0){
        switch (Activity)
        {
            case "breathing":
                if (numb==0){
                    _breathingCount+=1;
                } else{_breathingCount=numb;}
                
                break;
            case "reflection":
                if (numb==0){
                _reflectionCount+=1;
                }else{_reflectionCount=numb;}
                break;
            case "listing":
            if (numb==0){
                _listingCount+=1;
                }else{_listingCount=numb;}
                break;
            default:
                break;       
        }
        

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
        StartTimer(3);
        Console.WriteLine($"You completed another {_seconds} seconds of the {_activity} activity");
        StartTimer(3);
         switch (_activity)
        {
            case "breathing":
                Console.WriteLine($"You have compleated this activity {_breathingCount} times");
                break;
            case "reflection":
                Console.WriteLine($"You have compleated this activity {_reflectionCount} times");
                break;
            case "listing":
                Console.WriteLine($"You have compleated this activity {_listingCount} times");
                break;
        } 
        StartTimer(5);

    }
    
}