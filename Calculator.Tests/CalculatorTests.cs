using System;

namespace Calculator.Tests;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void ExistingOperation()
    {
        Calculator calculator = new();

        double result = calculator.Calculate("sin", 0.5);
        Assert.AreEqual(Math.Sin(0.5), result, 1e-5);
    }

    [TestMethod, ExpectedException(typeof(CalculatorException), AllowDerivedTypes = true)]
    public void NonExistingOperation()
    {
        Calculator calculator = new();

        double result = calculator.Calculate("non-existing-operation", 1, 2, 3);
    }

    [TestMethod, ExpectedException(typeof(CalculatorException), AllowDerivedTypes = true)]
    public void MissingArguments()
    {
        Calculator calculator = new();

        double result = calculator.Calculate("sin");
    }

    [TestMethod]
    public void WhatElseToTest()
    {
        Assert.Fail("TODO: Add more relevant tests. What tests can you add?");
    }

}