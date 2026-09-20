using System;
using System.Collections.Generic;

class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void ClearJournal()
    {
        _entries.Clear();
    }

    public List<Entry> GetEntries()
    {
        return _entries;
    }

    public void SetEntries(List<Entry> newEntries)
    {
        _entries = newEntries;
    }
}