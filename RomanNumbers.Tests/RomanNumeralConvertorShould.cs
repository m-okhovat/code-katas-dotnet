using codeKatas.RomanNumbers;
using FluentAssertions;

namespace RomanNumbers.Tests;

public class RomanNumeralConvertorShould
{
    [Theory]
    [InlineData(1, "I" )]
    [InlineData(2, "II" )]
    [InlineData(3, "III" )]
    [InlineData(4, "IV" )]
    public void convert_one(int number , string expectedRomanNumber)
    {
        var romanNumeralConvertor = new RomanNumeralConvertor();
        
        var romanNumber = romanNumeralConvertor.Convert(number);
        
        romanNumber.Should().Be(expectedRomanNumber);
    }
}

