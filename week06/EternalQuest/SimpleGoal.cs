using System;

public class SimpleGoal:Goal
{
     public SimpleGoal(string name, string description, int points, bool isCompleted = false)
        : base(name, description, points)
    {
        if (isCompleted)
        {
            MarkCompleted();
        }
    }
    public override void RecordEvent()
    {
        if (!IsCompleted())
        {
            MarkCompleted();
            Console.WriteLine($"You earned {GetPoints()} points!");
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
        }
    }
    

    public override string GetStatus()
    {
        string checkbox;

        if (IsCompleted())
        {
            checkbox = "X";
        }
        else
        {
            checkbox = " ";
        }

        return $"[{checkbox}] {GetName()} ({GetDescription()})";
    }
    
   public override string GetStringRepresentation()
    {

        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{IsCompleted()}";

    }
}
