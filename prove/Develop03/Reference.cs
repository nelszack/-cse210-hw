using System;

public class Reference{
     private string _referenceKey;



    public Reference(){

    }

    public string GetReferenceKey(){
        return _referenceKey;
    }
    public string SetReferenceKey(Dictionary<string,string> ScriptureDict){
        Random randnumb= new Random();
        int Number=randnumb.Next(ScriptureDict.Count());
        string key=ScriptureDict.Keys.ElementAt(Number);
        return _referenceKey=key;
    }

}