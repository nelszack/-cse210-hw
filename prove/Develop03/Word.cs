using System;

public class Word{
    private string[] _scriptureList;
    private string _scripture;

    public Word(){

    }
    public string[] GetScriptureList(){
        return _scriptureList;
    } 
    public string[] SetScriptureList(string Scripture){
        string[] Scripturelist=Scripture.Split(" ");
        return _scriptureList=Scripturelist;
    } 

    public string GetScripture(){
        return _scripture;
    }
    public string SetScripture(string Scripture){
        return _scripture=Scripture;
    }

    public string RemoveWords(string[] ScriptureList){
        int NumberOfChanges=0;
        int PosibleChanges=ScriptureList.Count(x=>!x.StartsWith('_'));
        if (PosibleChanges!=0){
            while (NumberOfChanges<4 && PosibleChanges>0)
            {
                Random Index=new Random();
                int RandIndex=Index.Next(ScriptureList.Count());
                if (!ScriptureList[RandIndex].StartsWith('_')){
                    int NumbLetters=ScriptureList[RandIndex].Count();
                    string dashes="";
                    for (int i=0;i<NumbLetters;i++){
                        switch(ScriptureList[RandIndex][i]){
                            case ',':
                                dashes+=",";
                                break;
                            case ';':
                                dashes+=";";
                                break;
                            case '.':
                                dashes+=".";
                                break;
                            default:
                                dashes+="_";
                                break;
                        }
                    }
                    ScriptureList[RandIndex]=dashes;
                    NumberOfChanges++;
                    PosibleChanges--;
                }
            }
        }
         string FullValue="";

        foreach (string i in ScriptureList)
        {
            FullValue+=i+" ";
        }
        return FullValue.Trim();
    }
}