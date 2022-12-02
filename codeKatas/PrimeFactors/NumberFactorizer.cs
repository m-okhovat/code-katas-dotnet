namespace codeKatas.PrimeFactors;

public class NumberFactorizer
{
    public int[] Factorize(int number)
    {
        var primeNumbers = PrimeNumbersLessThan(number);
        var results = new List<int>();

        if (primeNumbers.Contains(number))
            return new int[] {number};

        foreach (var primeNumber in primeNumbers)
        {
            while (number % primeNumber == 0)
            {
                results.Add(primeNumber);
                number /= primeNumber;
            }

            if (number == 1) break;
        }

        return results.ToArray();
    }

    private IEnumerable<int> PrimeNumbersLessThan(int number)
    {
        var primes = new List<int>();
        for (int i = 1; i <= number; i++)
        {
            short counter = 0;
            for (int j = 1; j  <= i / 2; j++)
            {
                if (i % j == 0) counter++;
            }

            if (counter == 1) primes.Add(i);
        }

        return primes;
    }
}