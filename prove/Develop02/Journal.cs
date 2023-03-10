public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public Journal() { }

    public void CreateJournalEntry()
    {
        Console.Clear();
        Console.WriteLine("New Entry:");
        string date = DateTime.Now.ToString("MM.dd.yyyy");
        string prompt = new PromptGenerator().GetRandomPrompt();
        Console.WriteLine($"{date} \n{prompt}");
        string response = Console.ReadLine();
        Entry _newEntry = new Entry(date, prompt, response);
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
            Entry entry = new Entry(splitString[0], splitString[1], splitString[2]);
            _entries.Add(entry);
        }
    }
}