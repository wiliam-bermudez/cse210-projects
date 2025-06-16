using System;

public class CheckListGoal:Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    
    public CheckListGoal(string name, string description, int points, int bonus, int targetCount, int currentCount = 0): base(name, description, points)
    {
        _target = targetCount;
        _amountCompleted = currentCount;
        _bonus = bonus;

        if (_amountCompleted >= _target)
        {
            MarkCompleted();
        }
    }

    public override void RecordEvent()
    {
         if (IsCompleted())
        {
            Console.WriteLine("This checklist goal has already been completed.");
            return;
        }

        _amountCompleted++;

        if (_amountCompleted >= _target)
        {
            MarkCompleted();
            Console.WriteLine($"You completed the checklist! You earned {GetPoints() + _bonus} points!");
        }
        else
        {
            Console.WriteLine($"Progress: {_amountCompleted}/{_target}. You earned {GetPoints()} points!");
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

    return "[" + checkbox + "] " + GetName() + " (" + GetDescription() + ") -- Completed " + _amountCompleted + "/" + _target + " times";
    }
    public override string GetStringRepresentation()
    {
       return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_bonus}|{_target}|{_amountCompleted}";
    }

    public override string GetDetailsString(){
        return "Goal: " + GetName() +
           "\nDescription: " + GetDescription() +
           "\nPoints per completion: " + GetPoints() +
           "\nTarget completions: " + _target +
           "\nCurrent completions: " + _amountCompleted +
           "\nBonus: " + _bonus;
    }
}