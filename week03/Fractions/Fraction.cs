public class Fraction
{
    // Private attributes for encapsulation
    private int _top;
    private int _bottom;

    // Constructor 1: No parameters, defaults to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor 2: One parameter, sets denominator to 1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor 3: Two parameters for numerator and denominator
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for top (numerator)
    public int GetTop()
    {
        return _top;
    }

    // Setter for top (numerator)
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for bottom (denominator)
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for bottom (denominator)
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Returns string representation (e.g., "3/4")
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns decimal value (e.g., 0.75)
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}