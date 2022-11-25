namespace codeKatas.RomanNumbers;

public class RomanNumeralConvertor
{
    public string Convert(int number)
    {
        if (number < 4)
        {
            var romans = new string[] {"I", "II","III"};
            return romans[number-1];    
        }

        return "IV";
    }
}