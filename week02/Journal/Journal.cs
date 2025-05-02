using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> _entries;
    private List<string> _prompts;
    private Random _random;

    public Journal()
    {
        _entries = new List<Entry>();
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What did I learn today that I want to remember?",
            "What made me laugh today?"
        };
        _random = new Random();
    }

    public void AddEntry()
    {
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        Console.Write("Enter mood (Happy, Sad, Neutral): ");
        string mood = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        _entries.Add(new Entry(prompt, response, date, mood));
        Console.WriteLine("Entry added!");
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal.");
            return;
        }
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void DisplayEntriesByMood(string mood)
    {
        bool found = false;
        foreach (Entry entry in _entries)
        {
            if (entry.Mood.Equals(mood, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(entry.ToString());
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine($"No entries found with mood: {mood}");
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine(entry.ToFileString());
                }
            }
            Console.WriteLine("Journal saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {
        try
        {
            _entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    _entries.Add(Entry.FromFileString(line));
                }
            }
            Console.WriteLine("Journal loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}