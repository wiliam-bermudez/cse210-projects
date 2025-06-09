using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind?"
    };
    public ReflectingActivity()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        Console.WriteLine($"Prompt: {GetRamdonPrompt()}");

        int totalTime = 0;
        while (totalTime < _duration)
        {
            Console.Write($"{GetRamdonQuestion()}");
            ShowSpinner(4);
            totalTime += 4;
        }

        DisplayEndingMessage();
    }

    public string GetRamdonPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }


    public string GetRamdonQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestions()
    {
        
    }

}

