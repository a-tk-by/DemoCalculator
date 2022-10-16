using System;

namespace Calculator;

internal sealed class FuncOperation : IOperation
{
    private readonly Func<double, double> function;

    public FuncOperation(Func<double, double> function)
    {
        this.function = function;
    }

    public double Calculate(double[] arguments)
    {
        arguments.EnsureAtLeast(1);
        return this.function(arguments[0]);
    }
}
