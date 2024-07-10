using System;

public class Comment
{
    private Dictionary<string, string> _comment = new();

    public Comment()
    {

    }

    public void StoreComment(string Name, string Message)
    {
        _comment.Add(Name, Message);
    }
    public Dictionary<string, string> GetDict()
    {
        return _comment;
    }


}