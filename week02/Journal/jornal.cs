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
                // Inclui as tags no final da linha, separadas por ;
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
            
            // Verifica se a linha tem o campo de tags
            if (parts.Length > 3)
            {
                newEntry._tags = new List<string>(parts[3].Trim('"').Split(';'));
            }

            _entries.Add(newEntry);
        }
    }
    
    public void SearchByTag(string tag)
    {
        Console.WriteLine($"--- Entries tagged with '{tag}' ---");
        bool found = false;
        foreach (Entry entry in _entries)
        {
            // Verifica se a tag existe na lista de tags da entrada
            if (entry._tags.Contains(tag.ToLower()))
            {
                entry.Display();
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("No entries found with that tag.");
        }
    }
}