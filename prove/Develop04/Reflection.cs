using System;

public class Reflection:Base{
    private List<string> _prompts=["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.","Think of a time when you helped someone in need","Think of a time when you did something truly selfless"];
    private List<string> _reflection=["Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"];
    private List<int>_usedreflection=[];

    public Reflection(string Message,string Activity="reflection"):base(Message,Activity){
       
    }
    
    public void DisplayActivity(){
        Console.WriteLine("Get ready ");
        StartTimer(5);
        int RandIndex;
        Random Index= new Random();
        RandIndex=Index.Next(_prompts.Count());
        Console.WriteLine($"consider the prompt:\n{_prompts[RandIndex]}");
        Console.WriteLine("If you have something in mind press enter");
        Console.ReadLine();
        Console.WriteLine($"Now ponder on each of the folloing questions as they related to this experience");
        StartTimer(5);
        Console.WriteLine("You may begin:\n");
        DateTime StartTime=DateTime.Now;
        DateTime EndTime=StartTime.AddSeconds(_seconds);
        while(DateTime.Now<EndTime){
            int RandIndex2;
            do
            {
                Random index2= new Random();
                RandIndex2=index2.Next(_reflection.Count());
                
            } while (_usedreflection.Contains(RandIndex2));
            if(!_usedreflection.Contains(RandIndex2)){
                    _usedreflection.Add(RandIndex2);
                }
            if (_usedreflection.Count()==_reflection.Count()){
                _usedreflection.Clear();
            }
            Console.Write($"{_reflection[RandIndex2]}");
            StartTimer(7);
            Console.WriteLine("");

        }
    }
}