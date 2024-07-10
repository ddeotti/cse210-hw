public class Journal
{
    public List<Entry> ListOfEntries = new List<Entry>();

    public void AddEntry(string entryDate, string promptText, string entryText)
    {
        Entry innerEntry = new Entry(entryDate, promptText, entryText);
        ListOfEntries.Add(innerEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry toListAll in ListOfEntries)
        {
            toListAll.Display();
        }
    }

    // File handling
    public void SaveToFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            using (StreamWriter outputFile = new StreamWriter(fileName, append: true))
            {
                foreach (Entry record in ListOfEntries)
                {
                    outputFile.WriteLine($"{record._date}; {record._promptText}; {record._entryText}");
                }
            }
            Console.WriteLine($"File {fileName} already exists, I just appended the new content.");
        }
        else
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (Entry record in ListOfEntries)
                {
                    outputFile.WriteLine($"{record._date}| {record._promptText}| {record._entryText}");
                }
            }
            Console.WriteLine($"File {fileName} created. ");
        }
    }


    public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            List<string> fileOpened = File.ReadAllLines(fileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();

            foreach (string contentOf in fileOpened)
            {
                string[] fileContent = contentOf.Split("| ");

                Entry journalEntryOfFileOpened = new Entry();
                journalEntryOfFileOpened._date = fileContent[0];
                journalEntryOfFileOpened._promptText = fileContent[1];
                journalEntryOfFileOpened._entryText = fileContent[2];
                ListOfEntries.Add(journalEntryOfFileOpened);
            }
        }
        else
        {
            Console.WriteLine($"File {fileName} does not exist.");
        }

    }

}
