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
        int number_of_changes=0;
        int posible_cnahges=ScriptureList.Count(x=>!x.StartsWith('_'));
        if (posible_cnahges!=0){
            while (number_of_changes<4 && posible_cnahges>0)
            {
                Random index=new Random();
                int randindex=index.Next(ScriptureList.Count());
                if (!ScriptureList[randindex].StartsWith('_')){
                    int NumbLetters=ScriptureList[randindex].Count();
                    string dashes="";
                    for (int i=0;i<NumbLetters;i++){
                        switch(ScriptureList[randindex][i]){
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
                    ScriptureList[randindex]=dashes;
                    number_of_changes++;
                    posible_cnahges--;
                }
            }
        }
         string fullvalue="";

        foreach (string i in ScriptureList)
        {
            fullvalue+=i+" ";
        }
        return fullvalue.Trim();
    }
}