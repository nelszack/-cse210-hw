using System;

public class Write{
    private string _date=DateTime.Now.ToLongDateString();
    private string _prompt;
    private string _responce;
    public List<string> _entries= new List<string>();

    public Write(){

    }

    public string GetPrompt(){
        List<string> Promptzn= new List<string>();
        Promptzn.Add("Who was the most interesting person I interacted with today?");
        Promptzn.Add("What was the best part of my day?");
        Promptzn.Add("How did I see the hand of the Lord in my life today?");
        Promptzn.Add("What was the strongest emotion I felt today?");
        Promptzn.Add("If I had one thing I could do over today, what would it be?");
        Promptzn.Add("What did you do today?");
        Promptzn.Add("What is something that you wished you have done better?");

        Random Random= new Random();
        int Number=Random.Next(Promptzn.Count());
        _prompt=Promptzn[Number];
        return Promptzn[Number];
    }
    public void GetResponce(string responce){
        _responce=responce;
    }
    public List<string> StoreEntry(){

        _entries.Add($"\"{_date}\",\"{_prompt}\",\"{_responce}\"");

        return _entries;
       
    }
    public void Display(){

         foreach (string i in _entries)
        {
            string[] j=i.Split("\",\"");
            if (j[2].EndsWith("\"")){
                j[2]=j[2].Trim('"');
            }
            if (j[0].StartsWith("\"")){
                j[0]=j[0].Trim('"');
            }
            // Console.WriteLine(i);
            // Console.WriteLine($"Date: {i[0]} Prompt:{i[1]}\n{i[2]}");
            Console.WriteLine($"Date: {j[0]} - Prompt: {j[1]}\n{j[2]}\n");
            
        }
    }

}