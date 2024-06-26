using System.Diagnostics;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructor
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

    // Getter and Setter
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Return Representations

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetFractionDecimal()
    {
        return (double)_top / (double)_bottom;
    }
}