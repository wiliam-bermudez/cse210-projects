using System;

class Entry
{
    public String _date;
    public String _prompttext;
    public String _entrytext;

    public Entry(string date, string prompttext, string entrytext)
    {
        _date = date;
        _prompttext = prompttext;
        _entrytext = entrytext;
    }

    public override string ToString()
    {
        return $"Date: {_date}\nPrompt: {_prompttext}\nResponse: {_entrytext}\n";
    }

      public string ToFileString()
    {
        return $"{_date}|{_prompttext}|{_entrytext}";
    }

    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length == 3)
        {
            return new Entry(parts[0], parts[1], parts[2]);
        }
        return null;
    }
    public void Display()
    {
        // Create an object to get a prompt
        PromptGenerator aPrompt = new PromptGenerator();
        // Call the method to get a random prompt
        Console.WriteLine(aPrompt.GetRandomPrompt());
    }

   


    
}
