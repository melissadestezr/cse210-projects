public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public void Display()
    {
        Console.Write($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}