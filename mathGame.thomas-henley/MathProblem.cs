namespace MathGame;

internal abstract class MathProblem
{
    public int X { get; set; }

    public int Y { get; set; }

    public char Operator { get; set; }

    /// <summary>
    /// The actual correct answer.
    /// </summary>
    public int Result { get; set; }

    /// <summary>
    /// The player's guess.
    /// </summary>
    public int PlayerAnswer { get; set; }

    public bool WasCorrect {  get; set; }


    /// <summary>
    /// The amount of time taken to answer the problem.
    /// </summary>
    public TimeSpan ResponseTime { get; set; }

    /// <summary>
    /// Compares the player's guess to the actual answer and stores the attempt.
    /// </summary>
    /// <param name="playerAnswer">Player's guess at the solution.</param>
    public void MakeAttempt(int playerAnswer)
    {
        PlayerAnswer = playerAnswer;
        WasCorrect = (playerAnswer == this.Result);
    }

    /// <summary>
    /// Displays the equation with the answer omitted, e.g. "4 + 32 = ".
    /// </summary>
    /// <returns></returns>
    public string ToStringPrompt()
    {
        return $"{X} {Operator} {Y} = ";
    }

    /// <summary>
    /// Displays the full equation with the player's stored answer, whether correct or not.
    /// </summary>
    /// <returns></returns>
    public string ToStringFull()
    {
        return ToStringPrompt() + PlayerAnswer;
    }

}
