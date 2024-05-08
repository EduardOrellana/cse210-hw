using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Fraction
{
    
    //Attributes, _top: Numerator and _botton Denominator:
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

    public string GetFractionString()
    {
        string fractionPrint = $"{_top}/{_bottom}";
        return fractionPrint;
    }

    public double GetDecimalValue()
    {
        double decimalValue = _top / _bottom;
        return decimalValue;
    }

}