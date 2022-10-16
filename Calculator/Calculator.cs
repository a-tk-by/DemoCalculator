using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculator;

public sealed class Calculator
{
    private readonly Dictionary<string, IOperation> operations = new(StringComparer.InvariantCultureIgnoreCase)
    {
        ["+"] = new SumOperation(),
        ["*"] = new MulOperation(),
        ["sin"] = new FuncOperation(Math.Sin),
        ["cos"] = new FuncOperation(Math.Cos),
        ["/"] = new Func2Operation((a, b) => a / b),
        ["-"] = new Func2Operation((a, b) => a - b),
        ["atan2"] = new Func2Operation(Math.Atan2),
        //TODO go on
    };

    public double Calculate(string operationName, params double[] arguments)
    {
        if (this.operations.TryGetValue(operationName, out var operation))
        {
            return operation.Calculate(arguments);
        }

        throw new OperationNotFoundException(operationName);
    }
}