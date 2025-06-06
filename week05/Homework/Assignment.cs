using System;


public class Assignment
{
    protected string _studentName;
    protected string _topic;


    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }


    public string GetSummary()
    {
        string summary = $"{_studentName} - {_topic}";
        
        return summary;
    }
}


