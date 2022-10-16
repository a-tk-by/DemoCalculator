namespace Calculator;

public sealed class OperationNotFoundException : CalculatorException
{
    public OperationNotFoundException(string operationName) : base($"Operation '{operationName}' not found")
    {
    }
}
