using System;

public class Video
{
    private string _title;
    private string _author;
    private int _time;
    private Comment _comments;


    public Video(string Title, string Author, int Time)
    {
        _time = Time;
        _title = Title;
        _author = Author;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetTime()
    {
        return _time;
    }
    public Comment GetComments()
    {
        return _comments;
    }
    public void SetComments(Comment comment)
    {
        _comments = comment;
    }
}