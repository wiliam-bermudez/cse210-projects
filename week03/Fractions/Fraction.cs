using System;

public class Fraction
{
    private int _bottom;
    private int _top;

    public Fraction()
    {
        _bottom = 1;
        _top = 1;
    }

    public Fraction(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }
    public string GetFractionString()
    {

        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        double division = _top / _bottom;
        return division;
    }

    
    

}