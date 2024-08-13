namespace MathGame;

internal class SubtractionProblem : MathProblem
{
    public SubtractionProblem(int max = 50)
    {
        Random rand = new();
        X = rand.Next(max);
        Y = rand.Next(max);
        Result = X - Y;
        Operator = '-';
    }
}
