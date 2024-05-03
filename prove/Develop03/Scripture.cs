using System;

public class Scripture{

    private Dictionary<string,string> _scriptureDict=new Dictionary<string, string>();

    public Scripture(){


    }

    public Dictionary<string,string> CreateScriptureDict(){
        _scriptureDict.Add("John 3:16","For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        _scriptureDict.Add("Proverbs 3:5-6","Trust in the Lord with all thine heart; and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        return _scriptureDict;
    }


}