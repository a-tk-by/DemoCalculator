namespace Calculator;

public sealed class NotEnoughArgumentsException : CalculatorException
{
    public NotEnoughArgumentsException(int requiredNumber, int actualNumber) : base($"Not enough arguments. {requiredNumber} expected, but {actualNumber} passed")
    {
    }
}
