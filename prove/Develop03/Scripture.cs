public class Scripture
{
    //Attributes
    private List<Word> _textList = new List<Word>();
    private List<Word> _referenceList = new List<Word>();
    private List<Word> _combinedList = new List<Word>();
    private int _wordCount;
    private int _wordsHidden;

    //Constructors
    public Scripture(Reference reference, string text)
    {
        _referenceList = reference.GetList();
        Array textArray = text.Split(" ");
        foreach (string s in textArray)
        {
            _textList.Add(new Word(s));
        }
        foreach (Word w in _referenceList)
        {
            _combinedList.Add(w);
        }
        foreach (Word w in _textList)
        {
            _combinedList.Add(w);
        }
        _wordCount = _combinedList.Count();
    }

    //Methods
    public void HideWords()
    {
        decimal hider = Math.Ceiling((Decimal)(_wordCount / 7));
        if (_wordCount > _wordsHidden)
        {
            while (hider > 0 && _wordsHidden < _wordCount)
            {
                int randomIndex = new Random().Next(0, _wordCount);
                if (!_combinedList[randomIndex].IsHidden())
                {
                    _combinedList[randomIndex].Hide();
                    hider -= 1;
                    _wordsHidden += 1;
                }
            }
        }
    }
    public void RevealWords()
    {
        decimal revealer = Math.Ceiling((Decimal)(_wordCount / 5));
        if (_wordsHidden > 0)
        {
            while (revealer > 0 && _wordsHidden > 0)
            {
                int randomIndex = new Random().Next(0, _wordCount);
                if (_combinedList[randomIndex].IsHidden())
                {
                    _combinedList[randomIndex].Reveal();
                    revealer -= 1;
                    _wordsHidden -= 1;
                }
            }
        }
    }
    public void DisplayScripture()
    {
        foreach (Word w in _referenceList)
        {
            Console.Write(w.Display());
        }
        Console.WriteLine();
        foreach (Word w in _textList)
        {
            Console.Write(w.Display() + " ");
        }
    }
    public bool GameOn()
    {
        if (_wordsHidden == _wordCount)
        {
            return false;
        }
        else return true;
    }
}