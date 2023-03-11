class Fraction
{
    //Attributes
    private int _top;
    private int _bottom;

    //Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //Getters and Setters (ew)
    public int GetTopValue()
    {
        return _top;
    }
    public int GetBottomValue()
    {
        return _bottom;
    }
    public void SetTopValue(int top)
    {
        _top = top;
    }
    public void SetBottomValue(int bottom)
    {
        _bottom = bottom;
    }

    //Methods
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}