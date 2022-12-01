using codeKatas.Fibonacci;
using FluentAssertions;

namespace Fibbonacci.Tests;

public class FibonacciGeneratorShould
{
    // 0 1 1 2 3 5 8 13 ...
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 3)]
    [InlineData(5, 5)]
    [InlineData(6, 8)]
    [InlineData(7, 13)]
    [InlineData(8, 21)]
    [InlineData(9, 34)]
    [InlineData(10, 55)]
    [Theory]
    public void Generate_corresponding_fibonacci_number_for_the_given_index(int index, int result)
    {
        var fibNumber = new FibonacciGenerator().Generate(index);
        
        fibNumber.Should().Be(result);
    }
}

