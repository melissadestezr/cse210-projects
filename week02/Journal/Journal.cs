public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        filename = "myJournal.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry.GetSaveString()}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {   
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach(string line in lines)
        {
            Entry entry = Entry.FromSaveString(line);
            _entries.Add(entry);
        }
    }
}