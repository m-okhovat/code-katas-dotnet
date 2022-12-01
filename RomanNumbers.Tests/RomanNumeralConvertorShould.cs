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
    [InlineData(5, "V" )]
    [InlineData(6, "VI" )]
    [InlineData(7, "VII" )]
    [InlineData(8, "VIII" )]
    [InlineData(9, "IX" )]
    [InlineData(10, "X" )]
    [InlineData(12, "XII" )]
    [InlineData(13, "XIII" )]
    [InlineData(20, "XX" )]
    [InlineData(30, "XXX" )]
    [InlineData(32, "XXXII" )]
    // [InlineData(40, "XL" )]
    // [InlineData(50, "L" )]
    // [InlineData(60, "LX" )]
    // [InlineData(70, "LXX" )]
    // [InlineData(80, "LXXX" )]
    // [InlineData(90, "XC" )]
    // [InlineData(95, "XCV" )]
    // [InlineData(100, "C" )]
    public void convert_one(int number , string expectedRomanNumber)
    {
        var romanNumeralConvertor = new RomanNumeralConvertor();
        
        var romanNumber = romanNumeralConvertor.Convert(number);
        
        romanNumber.Should().Be(expectedRomanNumber);
    }
}

