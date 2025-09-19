using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void Display()
    {
        Console.WriteLine("--- Journal Entries ---");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"\"{entry._date}\",\"{entry._promptText}\",\"{entry._entryText}\",\"{string.Join(";", entry._tags)}\"");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(new string[] { "\",\"" }, StringSplitOptions.None);
            
            Entry newEntry = new Entry();
            newEntry._date = parts[0].Trim('"');
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2].Trim('"');
            
            if (parts.Length > 3)
            {
                newEntry._tags = new List<string>(parts[3].Trim('"').Split(';'));
            }

            _entries.Add(newEntry);
        }
    }
}