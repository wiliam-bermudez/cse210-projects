using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    private bool _isCompleted;


    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isCompleted = false;
    }

    public string GetName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public bool IsCompleted()
    {
        return _isCompleted;
    }

    protected void MarkCompleted()
    {
        _isCompleted = true;
    }
    public abstract void RecordEvent();
    public abstract string GetStatus();
    public abstract string GetStringRepresentation();
    public virtual string GetDetailsString()
    {
        return "";

    }

    
   public static Goal LoadFromString(string data)
{
    string[] parts = data.Split('|');
    string type = parts[0];

    if (type == "SimpleGoal")
    {
        return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
    }
    else if (type == "EternalGoal")
    {
        return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
    }
    else if (type == "ChecklistGoal")
    {
        return new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
    }
    else
    {
        throw new Exception("Invalid goal type");
    }
}
}