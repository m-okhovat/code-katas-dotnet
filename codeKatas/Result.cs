using System.Numerics;

namespace codeKatas;

class Result
{


    public static void extraLongFactorials(int n)
    {

        var result = factorial(n);

        Console.WriteLine(result);

    }

    private static long factorial(int n)
    {
        if (n == 1) return 1;
        if (n == 0) return 0;

        return n * factorial(n - 1);
    }

}
