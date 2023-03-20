public abstract class Shape
{
    string _color = "";

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string s)
    {
        _color = s;
    }

    public abstract double GetArea();
}