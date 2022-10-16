using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    internal static class CheckExtensions
    {
        public static double[] EnsureAtLeast(this double[] arguments, int requiredNumber)
        {
            if (arguments.Length < requiredNumber)
            {
                throw new NotEnoughArgumentsException(requiredNumber, arguments.Length);
            }

            return arguments;
        }
    }
}
