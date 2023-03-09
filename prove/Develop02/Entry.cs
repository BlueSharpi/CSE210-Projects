public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void DisplayEntry()
    {
        string result = "\n" + _date + "\n" + _prompt + "\n" + _response;
        Console.WriteLine($"{result}");
    }
    public string FormatEntryForCSV()
    {
        string result = string.Format("{0} | {1} | {2}", _date, _prompt, _response);
        return result;
    }
}