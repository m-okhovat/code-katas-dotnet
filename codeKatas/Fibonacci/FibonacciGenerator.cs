namespace codeKatas.Fibonacci;

public class FibonacciGenerator
{
    public int Generate(int index)
    {
        var numbers = new int[] {0, 1, 1};

        if (index < 3)
            return numbers[index];

        return Generate(index -1) + Generate(index -2);
    }
}