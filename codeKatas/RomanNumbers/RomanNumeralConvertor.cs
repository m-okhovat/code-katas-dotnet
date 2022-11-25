namespace codeKatas.RomanNumbers;

public class RomanNumeralConvertor
{
    public string Convert(int i)
    {
        var romans = new string[] {"I", "II","III"};
        return romans[i-1];
    }
}