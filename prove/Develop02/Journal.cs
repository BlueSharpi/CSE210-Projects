public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public Journal() { }

    public void CreateJournalEntry()
    {
        Console.Clear();
        Console.WriteLine("New Entry:");
        Entry _newEntry = new Entry();
        _newEntry._date = DateTime.Now.ToString("MM.dd.yyyy");
        _newEntry._prompt = new PromptGenerator().GetRandomPrompt();
        Console.WriteLine($"{_newEntry._date} \n{_newEntry._prompt}");
        _newEntry._response = Console.ReadLine();
        _entries.Add(_newEntry);
    }
    public void DisplayJournalEntries()
    {
        Console.Clear();
        Console.WriteLine("\n---------- Previous Entries ----------");
        if (_entries.Count < 1)
        {
            Console.WriteLine("\nNothing to Display.");
        }
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
        Console.Write("\nPress Enter to return to Menu");
        Console.ReadLine();
    }
    public void SaveToCSV()
    {
        List<string> record = new List<string>();
        foreach (Entry entry in _entries)
        {
            record.Add(entry.FormatEntryForCSV());
        }
        Console.Write("Input file name to save: ");
        string _fileName = Console.ReadLine() + ".csv";
        File.WriteAllLines(_fileName, record);
    }
    public void LoadFromCSV()
    {
        Console.Write("Input file name to load: ");
        string _fileName = Console.ReadLine() + ".csv";

        List<string> record = System.IO.File.ReadAllLines(_fileName).ToList();
        foreach (string line in record)
        {
            string[] splitString = line.Split('|');
            Entry entry = new Entry();
            entry._date = splitString[0];
            entry._prompt = splitString[1];
            entry._response = splitString[2];
            _entries.Add(entry);
        }
    }
}