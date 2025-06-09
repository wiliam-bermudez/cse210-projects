using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} Activity ---\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("Enter duration (seconds): ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3);
    }

    
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = ["/", "-", "\\", "|" ];
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;


            if (i >= spinner.Count())
            {
                i = 0;
            }
        }
       
    }
    
    

    public void ShowCountDown(int seconds)
    {   
       for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }

        Console.WriteLine("Done");
    }
}
