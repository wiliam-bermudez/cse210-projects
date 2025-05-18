using System;
using System.IO;

class Journal
{
    List<Entry> _entries;

    // METHODS START
    public Journal()
    {
        _entries = new List<Entry>();
       
    }


    public void Display()
    {
        Console.WriteLine("----Journal Entries-----");
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.ToString());
        }
        
    }

    public void AddEntry()
    {
        PromptGenerator _promptGen = new PromptGenerator();
        string prompt = _promptGen.GetRandomPrompt();
        Console.WriteLine($"{prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("MM-dd-yyyy");

        Entry newEntry = new Entry(date, prompt, response);
        _entries.Add(newEntry);
        Console.WriteLine("Entry added.");
    }

    public void SaveToFile(string file)
    {

        string date = DateTime.Now.ToString("MM-dd-yyyy");

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine($"My Journal {date}");
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToFileString());
            }
        }
        Console.WriteLine("Journal saved successfully.");

    }

    public void LoadFromFile(string file)
    {
         if (File.Exists(file))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                Entry entry = Entry.FromFileString(line);
                if (entry != null)
                {
                    _entries.Add(entry);
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
    
}