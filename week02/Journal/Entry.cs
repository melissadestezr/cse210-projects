public class Entry
{
    public string _date;
    public string _promptText;

    public string _entryText;

    public Entry(string promptText, string entryText)
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = promptText;
        _entryText = entryText;
    }
    
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine();
    }

    public string GetSaveString()
    {
        return $"{_date} - {_promptText} - {_entryText}";
    }

     public static Entry FromSaveString(string line)
    {
        string[] parts = line.Split("-");
        Entry entry = new Entry(parts[1], parts[2]);
        entry._date = parts[0];
        return entry;
    }
}