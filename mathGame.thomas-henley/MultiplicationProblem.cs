namespace MathGame;

internal class MultiplicationProblem : MathProblem
{

    public MultiplicationProblem(int max = 15)
    {
        Random rand = new();
        X = rand.Next(max);
        Y = rand.Next(max);
        Result = X * Y;
        Operator = '*';
    }
}
