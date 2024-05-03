using System;

public class Reference{
     private string _referenceKey;



    public Reference(){

    }

    public string GetReferenceKey(){
        return _referenceKey;
    }
    public string SetReferenceKey(Dictionary<string,string> ScriptureDict){
        Random RandNumb= new Random();
        int Number=RandNumb.Next(ScriptureDict.Count());
        string key=ScriptureDict.Keys.ElementAt(Number);
        return _referenceKey=key;
    }

}