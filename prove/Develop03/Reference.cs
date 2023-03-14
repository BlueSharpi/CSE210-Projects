public class Reference
{
    //Attributes
    private List<Word> _rList = new List<Word>();
    private string _book = "";
    private string _chapter = "";
    private string _verse = "";
    private string _endVerse = "";

    //Constructors
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        FormatReference();
    }
    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
        FormatReference();
    }

    //Methods
    private void FormatReference()
    {
        _rList.Add(new Word(_book + " "));
        _rList.Add(new Word(_chapter + ":"));
        _rList.Add(new Word(_verse));
        if (_endVerse != "")
        {
            _rList.Add(new Word("-" + _endVerse));
        }
    }

    public List<Word> GetList()
    {
        return _rList;
    }
}