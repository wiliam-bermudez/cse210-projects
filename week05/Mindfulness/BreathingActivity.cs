using System;

public class BreathingActivity:Activity
{
    
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void run()
    {
        DisplayStartingMessage();

        int totalTime = 0;

        while (totalTime < _duration)
        {
            Console.Write("Breath in...");
            ShowCountDown(4);
            totalTime = +4;

             if (totalTime >= _duration) break;

            Console.WriteLine("Breathe out...");
            ShowCountDown(4);
            totalTime += 4;
        }
        DisplayEndingMessage();
    }
}