using System;

public class Scripture{

    private Dictionary<string,string> _scriptureDict=new Dictionary<string, string>();

    public Scripture(){


    }

    public Dictionary<string,string> CreateScriptureDict(){
        _scriptureDict.Add("John 3:16","For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        _scriptureDict.Add("Proverbs 3:5-6","Trust in the Lord with all thine heart; and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        _scriptureDict.Add("Moroni 10:4","And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.");
        return _scriptureDict;
    }


}