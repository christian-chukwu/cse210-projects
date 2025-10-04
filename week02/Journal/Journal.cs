using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
  private List<Entry> _entries = new List<Entry>();

  public void AddEntry(Entry entry)
  {
    _entries.Add(entry);
  }

  public void DisplayJournal()
  {
    if (_entries.Count == 0)
    {
      Console.WriteLine("No journal entries to display.");
      return;
    }

    foreach (Entry entry in _entries)
    {
      Console.WriteLine($"Date: {entry.Date}");
      Console.WriteLine($"Prompt: {entry.Prompt}");
      Console.WriteLine($"Response: {entry.Response}");
      Console.WriteLine("-----------------------------");
    }
  }

  public void SaveToFile(string filename)
  {
    using (StreamWriter writer = new StreamWriter(filename))
    {
      foreach (Entry entry in _entries)
      {
        writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
      }
    }
    Console.WriteLine("Journal saved successfully.");
  }

  public void LoadFromFile(string filename)
  {
    _entries.Clear();
    if (!File.Exists(filename))
    {
      Console.WriteLine("File not found.");
      return;
    }

    foreach (string line in File.ReadAllLines(filename))
    {
      string[] parts = line.Split('|');
      if (parts.Length == 3)
      {
        Entry entry = new Entry(parts[1], parts[2], parts[0]);
        _entries.Add(entry);
      }
    }
    Console.WriteLine("Journal loaded successfully.");
  }
}