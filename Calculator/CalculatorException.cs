using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public abstract class CalculatorException : Exception
    {
        protected CalculatorException() { }

        protected CalculatorException(string message) : base(message) { }

        protected CalculatorException(string message, Exception innerException) : base(message, innerException) { }
    }
}
