using codeKatas.PrimeFactors;
using FluentAssertions;

namespace PrimeFactors.Tests;

public class PrimeFactorsShould
{
    [Theory]
    [InlineData(2, new int[] {2})]
    [InlineData(3, new int[] {3})]
    [InlineData(4, new int[] {2,2})]
    [InlineData(5, new int[] {5})]
    [InlineData(6, new int[] {2,3})]
    [InlineData(7, new int[] {7})]
    [InlineData(8, new int[] {2,2,2})]
    [InlineData(9, new int[] {3,3})]
    [InlineData(10, new int[] {2,5})]
    [InlineData(11, new int[] {11})]
    [InlineData(12, new int[] {2,2,3})]
    public void factorize_a_positive_number_to_its_prime_factors(int number, int[] factors)
    {
        int[] results = new NumberFactorizer().Factorize(number);

        results.Should().BeEquivalentTo(factors);
    }
}