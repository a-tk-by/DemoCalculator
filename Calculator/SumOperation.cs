using System.Linq;

namespace Calculator;

internal sealed class SumOperation : IOperation
{
    public double Calculate(double[] arguments) => arguments.Sum();
}
