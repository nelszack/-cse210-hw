using System;

public class Load{
    
    public Load(){

    }

    public void LoadEnteries(List<string> Enteries){
        Console.Write("where do you want to load from ");
        string FileName=Console.ReadLine();
        string[] Lines=System.IO.File.ReadAllLines(FileName);
        foreach (string Line in Lines)
        {
            Enteries.Add(Line);
        }
    }   

    public void SaveEnteries(List<string> Enteries){
        Console.Write("where do you want to save the enteries ");
        string FileName=Console.ReadLine();
        using (System.IO.StreamWriter output=new StreamWriter(FileName))
        {
            foreach (string Entery in Enteries)
            {
                output.WriteLine(Entery);
            }
        }

    }






}
