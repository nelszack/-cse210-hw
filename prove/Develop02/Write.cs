using System;

public class Write{
    private string _date=DateTime.Now.ToLongDateString();
    private string _prompt;
    private string _responce;
    public List<string> _entries= new List<string>();

    public Write(){

    }

    public string GetPrompt(){
        List<string> prompt= new List<string>();
        prompt.Add("Who was the most interesting person I interacted with today?");
        prompt.Add("What was the best part of my day?");
        prompt.Add("How did I see the hand of the Lord in my life today?");
        prompt.Add("What was the strongest emotion I felt today?");
        prompt.Add("If I had one thing I could do over today, what would it be?");

        Random random= new Random();
        int number=random.Next(0,5);
        _prompt=prompt[number];
        return prompt[number];
    }
    public void GetResponce(string responce){
        _responce=responce;
    }
    public List<string> StoreEntry(){
        _entries.Add($"date: {_date} prompt: {_prompt}\n{_responce}\n ");

        return _entries;
       
    }
    public void Display(){

         foreach (string i in _entries)
        {
            Console.WriteLine(i);
            
        }
    }

}