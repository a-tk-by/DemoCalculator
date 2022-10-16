using System.Linq;

namespace Calculator;

internal sealed class MulOperation : IOperation
{
    public double Calculate(double[] arguments) => arguments.EnsureAtLeast(1).Aggregate(1.0, (a, b) => a * b);
}
