using System;

public class ListingActivity : Activity
{

    private int _count;
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("You may be listing in...");
        ShowCountDown(3);

        List<string> items = GetListFromUser();
        Console.WriteLine($"\nYou listed {items.Count} items.");
        DisplayEndingMessage();
    }

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by listing as many things as you can.";
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();

        return _prompts[rand.Next(_prompts.Count())];
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (startTime > endTime)
        {
            Console.Write(">");
            string userInput = Console.ReadLine();
            if (userInput != "" || userInput != " ")
            {
                items.Add(userInput);
            }
        }
        return items;
        
    }


}