using System;

public class Reflection:Base{
    private List<string> _prompts=["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.","Think of a time when you helped someone in need","Think of a time when you did something truly selfless"];
    private List<string> _reflection=["Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"];


    public Reflection(string message,string activity="reflection"):base(message,activity){
       
    }
    
    public void DisplayActivity(){
        Console.WriteLine("Get ready ");
        StartTimer(5);
        Random index= new Random();
        int RandIndex=index.Next(_prompts.Count());
        Console.WriteLine($"consider the prompt:\n{_prompts[RandIndex]}");
        Console.WriteLine("if you have something in mind press enter");
        Console.ReadLine();
        Console.Write($"now ponder on each of the folloing questions as they related to this experience\n");
        StartTimer(5);
        Console.WriteLine("you may begin:");
        Console.WriteLine("");
        DateTime startTime=DateTime.Now;
        DateTime endtime=startTime.AddSeconds(_seconds);
        while(DateTime.Now<endtime){
            Random index2= new Random();
            int RandIndex2=index2.Next(_reflection.Count());
            Console.Write($"{_reflection[RandIndex2]}");
            StartTimer(7);
            Console.WriteLine("");

        }
    }
}