public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        string filename = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
        outputFile.WriteLine($"");
        }
    }
}