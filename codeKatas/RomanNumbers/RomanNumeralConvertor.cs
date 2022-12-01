namespace codeKatas.RomanNumbers;

public class RomanNumeralConvertor
{
    private Dictionary<int, string> _numbers =  new Dictionary<int, string>()
    {
        {1, "I"},
        {4, "IV"},
        {5, "V"},
        {9, "IX"},
        {10, "X"},
        {40, "XL"},
        {50, "L"},
    };

    public string Convert(int number)
    {
      
        var result = string.Empty;
       
        while (number >= 50)
        {
            number -= 50;
            result += getValue(50);
        }

        while (number >= 40)
        {
            number -= 40;
            result += getValue(40);
        }

        while (number >= 10)
        {
            number -= 10;
            result += getValue(10);
        }

        while (number >= 9)
        {
            number -= 9;
            result += getValue(9);
        }

        while (number >= 5)
        {
            number -= 5;
            result += getValue(5);
        }

        while (number >= 4)
        {
            number -= 4;
            result += getValue(4);
        }

        while (number >= 1)
        {
            number -= 1;
            result += getValue(1);
        }

        return result;
    }

    private string? getValue(int number)
    {
        _numbers.TryGetValue(number, out var result);
        return result;
    }
}
