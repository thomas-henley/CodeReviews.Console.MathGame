namespace MathGame;

internal class AdditionProblem : MathProblem
{
    public AdditionProblem(int max = 50)
    {
        Random rand = new();
        X = rand.Next(max);
        Y = rand.Next(max);
        Result = X + Y;
        Operator = '+';
    }
}
