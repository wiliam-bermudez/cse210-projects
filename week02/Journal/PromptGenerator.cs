using System;
using System.Collections.Generic;

class PromptGenerator
{
    public List<String> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>();
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("Did I learn something new today?");
        _prompts.Add("What habits do I want to build or break?");
        _prompts.Add("Who am I when no one is watching?");
        _prompts.Add("Who made me feel supported today?");
        _prompts.Add("What am I grateful for today?");
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}