public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry() { }


    public Entry(string inDate, string inPrompt, string inEntry)
    {
        _date = inDate;
        _promptText = inPrompt;
        _entryText = inEntry;
    }

    public void Display()
    {
        Console.WriteLine("");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}