using System;
using System.Collections.Generic;

public class Comment
{
    public string _text;
    public string _commenterName;


    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"  - {_commenterName}: {_text}");
    }
}