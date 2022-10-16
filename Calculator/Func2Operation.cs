using System;

namespace Calculator;

internal class Func2Operation : IOperation
{
    private readonly Func<double, double, double> function;

    public Func2Operation(Func<double, double, double> function)
    {
        this.function = function;
    }

    public double Calculate(double[] arguments)
    {
        arguments.EnsureAtLeast(2);
        return this.function(arguments[0], arguments[1]);
    }
}
