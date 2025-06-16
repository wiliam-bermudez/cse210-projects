using System;

public class EternalGoal:Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
            
    }
    public override void RecordEvent()
    {
         Console.WriteLine($"You earned {GetPoints()} points!");
    }
    public override string GetStatus()
    {
        return $"[∞] {GetName()} ({GetDescription()})";
    }
    public override string GetStringRepresentation()
    {
        
        return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
    
    }
}