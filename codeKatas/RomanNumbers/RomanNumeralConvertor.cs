namespace codeKatas.RomanNumbers;

public class RomanNumeralConvertor
{
    public string Convert(int number)
    {
        var numbers = new Dictionary<int, string>()
        {
            {1, "I"},
            {2, "II"},
            {3, "III"},
            {4, "IV"},
            {5, "V"},
            {9, "IX"},
            {10, "X"},
        };

        var result = string.Empty;

        if (numbers.ContainsKey(number))
        {
            result = getValue(number, numbers);

            return result;
        }
        
        if (number > 10)
            return getValue(10, numbers) + Convert(number - 10);

        if (number < 9)
            return getValue(5, numbers) + Convert(number - 5);

        return string.Empty;
        // if (RomanDigitStore.HasKey(number)) 
        //     return  RomanDigitStore.GetByKey(number);
        //
        //
        //
        //
        // while (number < 4)
        // {
        //     return Convert(number-1) + RomanDigitStore.GetByKey(1);
        // }
        //
        // if(number<10)
        // return RomanDigitStore.GetByKey(5) + Convert(number - 5);
        //
        // if (number < 50)
        // return RomanDigitStore.GetByKey(10) + Convert(number - 10);
        //
        // if(number < 90)
        // return RomanDigitStore.GetByKey(50) + Convert(number - 50);
        //
        // return RomanDigitStore.GetByKey(90) + Convert(number - 90);
    }

    private static string? getValue(int number, Dictionary<int, string> numbers)
    {
        numbers.TryGetValue(number, out var result);
        return result;
    }
}

public static class RomanDigitStore
{
    private static readonly Dictionary<int, string> _collection = new Dictionary<int, string>()
    {
        {1, "I"},
        {4, "IV"},
        {5, "V"},
        {9, "IX"},
        {10, "X"},
        {40, "XL"},
        {50, "L"},
        {90, "XC"},
        {100, "C"},
    };

    public static string GetByKey(int number)
    {
        _collection.TryGetValue(number, out var result);

        return result;
    }

    public static bool HasKey(int number)
    {
        return _collection.ContainsKey(number);
    }
}