using System;

public class MathAssignment : Assignment{
    private string _textbookSelection;
    private string _problems;

    public MathAssignment(string name,string topic,string textbook,string problems): base(name,topic){
        _textbookSelection=textbook;
        _problems=problems;

    }
    public string GetHomworkList(){
        return $"{_textbookSelection} {_problems}";
    }
}