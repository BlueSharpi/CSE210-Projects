public class Word
{
    private string _value;
    private string _hiddenValue = "";
    private bool _isHidden = false;

    public Word(string word)
    {
        _value = word;
        foreach (char c in word)
        {
            if (Char.IsPunctuation(c) || Char.IsWhiteSpace(c))
            {
                _hiddenValue += c;
            }
            else
            {
                _hiddenValue += "_";
            }
        }
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Reveal()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        if (_isHidden)
        {
            return true;
        }
        else return false;
    }
    public string Display()
    {
        if (_isHidden == true)
        {
            string result = _hiddenValue;
            return result;
        }
        else
        {
            string result = _value;
            return result;
        }
    }
}