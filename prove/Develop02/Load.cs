using System;

public class Load{
    private string[] _loadedEnteries;
    public Load(){

    }

    public void LoadEnteries(List<string> Enteries){
        Console.Write("where do you want to load from ");
        string FileName=Console.ReadLine();
        _loadedEnteries=System.IO.File.ReadAllLines(FileName);
        foreach (string Line in _loadedEnteries)
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
