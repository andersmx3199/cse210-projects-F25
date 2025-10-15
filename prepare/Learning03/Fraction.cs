public class Fraction 
{
    private int _topNum;
    private int _bottomNum;

    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;
    }

    public Fraction(int wholeNum)
    {
        _topNum = wholeNum;
        _bottomNum = 1;
    }

    public Fraction(int topNum, int botNum)
    {
        _topNum = topNum;
        _bottomNum = botNum;
    }

    public string GetFractionString()
    {
        string fractionString = ($"{_topNum} / {_bottomNum}");
        return fractionString;
    }

    public double GetDecimalValue()
    {
        double decimalVal = (double)_topNum / (double)_bottomNum;
        return decimalVal;
    }
}