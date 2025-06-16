using System;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\nYour current score is: {_score} points\n");
    }

    public void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetStatus()}");
            index++;
        }
        Console.WriteLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nSelect the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter choice: ");
        string input = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (input == "1") // SimpleGoal
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (input == "2") // EternalGoal
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (input == "3") // ChecklistGoal
        {
            Console.Write("Enter number of times to complete: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new CheckListGoal(name, description, points, bonus, target));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }
    
    public void RecordEvent()
   {
    Console.WriteLine("\nWhich goal did you accomplish?");

    for (int i = 0; i < _goals.Count; i++)
    {
        Console.WriteLine((i + 1) + ". " + _goals[i].GetName());
    }

    Console.Write("Enter number: ");
    string input = Console.ReadLine();

    int choice;
    bool isNumber = int.TryParse(input, out choice);

    if (isNumber && choice > 0 && choice <= _goals.Count)
    {
        Goal selectedGoal = _goals[choice - 1];

        int oldScore = _score;

        StringWriter writer = new StringWriter();
        TextWriter originalConsole = Console.Out;
        Console.SetOut(writer);

        selectedGoal.RecordEvent();

        Console.SetOut(originalConsole);

        string output = writer.ToString();
        Console.Write(output);

        string[] lines = output.Split('\n');

        foreach (string line in lines)
        {
            if (line.Contains("You earned"))
            {
                string[] parts = line.Split(' ');
                foreach (string part in parts)
                {
                    int points;
                    if (int.TryParse(part, out points))
                    {
                        _score += points;
                        break;
                    }
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Invalid choice. Please try again.");
    }
}

    public void SaveGoals()
    {
        Console.Write("Enter filename to save to: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load from: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            Goal goal = Goal.LoadFromString(lines[i]);
            _goals.Add(goal);
        }

        Console.WriteLine("Goals loaded.");
    }

}