using System;

public class Write{
    private string _date=DateTime.Now.ToLongDateString();
    private string _prompt;
    private string _responce;
    public List<string> _entries= new List<string>();

    public Write(){

    }

    public string GetPrompt(){
        List<string> Prompt= new List<string>();
        Prompt.Add("Who was the most interesting person I interacted with today?");
        Prompt.Add("What was the best part of my day?");
        Prompt.Add("How did I see the hand of the Lord in my life today?");
        Prompt.Add("What was the strongest emotion I felt today?");
        Prompt.Add("If I had one thing I could do over today, what would it be?");

        Random Random= new Random();
        int Number=Random.Next(0,5);
        _prompt=Prompt[Number];
        return Prompt[Number];
    }
    public void GetResponce(string responce){
        _responce=responce;
    }
    public List<string> StoreEntry(){

        _entries.Add($"{_date}|{_prompt}|{_responce}");

        return _entries;
       
    }
    public void Display(){

         foreach (string i in _entries)
        {
            string[] j=i.Split("|");
            // Console.WriteLine(i);
            Console.WriteLine($"Date: {j[0]} Prompt:{j[1]}\n{j[2]}");
            
        }
    }

}