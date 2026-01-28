using System.IO; 
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
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        filename = "myJournal.txt";
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("-");
            Entry entry = new Entry(parts[1], parts[2]);
            _entries.Add(entry);
        }
    }
}