using System;

public class Fraction

{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top    = 1;
        _bottom = 1;

    }

    public Fraction(int wholeNumber)
    {
       _top = wholeNumber;
       _bottom= 1;
       

    }

    public Fraction (int _top, int _bottom)
    {
      _top = 1;
      _bottom = 1;

    }

    public string GetFractionString()
    {
        return $"{ _top} { _bottom} ";
    }
}