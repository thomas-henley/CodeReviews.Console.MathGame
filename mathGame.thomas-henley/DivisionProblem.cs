namespace MathGame;

internal class DivisionProblem : MathProblem
{
    readonly int[] PRIMES = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97];
    public DivisionProblem(int max = 100)
    {
        Random rand = new();

        do
        {
            X = rand.Next(max);
        } while (PRIMES.Contains(X));

        List<int> factors = GetFactors();

        Y = factors[rand.Next(factors.Count)];

        Result = X / Y;

        Operator = '/';
    }

    private List<int> GetFactors()
    {
        List<int> factors = [];
        for (int i = 1; i < X; i++)
        {
            if (X % i == 0)
            {
                factors.Add(i);
            }
        }
        return factors;
    }
}
