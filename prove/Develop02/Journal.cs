using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;

public class Journal
{
    private List<Entry> entries;
    private List<string> prompts;

    public Journal()
    {
        entries = new List<Entry>();
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    public void AddEntry(string response)
    {
        Random rnd = new Random();
        string prompt = prompts[rnd.Next(prompts.Count)];
        entries.Add(new Entry(prompt, response));
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string filename)
    {
        using(StreamWriter writer = new StreamWriter(filename))
        {
            foreach(var entry in entries)
            {
                writer.WriteLine($"{entry._date}~|~{entry._prompt}~|~{entry._response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(new string[] {"~|~"}, StringSplitOptions.None);
                if (parts.Length == 3)
                {
                    entries.Add(new Entry(parts[1], parts[2]) {_date = parts[0]});
                }
            }
        }
    }
    
}