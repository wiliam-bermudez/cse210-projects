using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count();
    }

    public void Display()
    {
        Console.WriteLine($"Tittle: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");

        foreach (Comment comm in _comments)
        {
            comm.DisplayComment();
        }
        Console.WriteLine("---------------------------------------------------");
    }
}