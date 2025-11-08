using CalculatorNamespace;
using Calc = CalculatorNamespace.Calculator;

namespace Calculator.Tests;

public class Tests
{
    [Test]
    public void TestAddPositiveNumbers()
    {
        var calc = new Calc(5, 7, '+');
        Assert.That(calc.Calculate(), Is.EqualTo(12));
    }

    [Test]
    public void TestAddNegativeNumbers()
    {
        var calc = new Calc(-2, -3, '+');
        Assert.That(calc.Calculate(), Is.EqualTo(-5));
    }

    [Test]
    public void TestAddDifferentSignsNumbers()
    {
        var calc = new Calc(-10, 15, '+');
        Assert.That(calc.Calculate(), Is.EqualTo(5));
    }

    [Test]
    public void TestAddZeroToPositiveNumber()
    {
        var calc = new Calc(5, 0, '+');
        Assert.That(calc.Calculate(), Is.EqualTo(5));
    }

    [Test]
    public void TestAddZeroToNegativeNumber()
    {
        var calc = new Calc(-5, 0, '+');
        Assert.That(calc.Calculate(), Is.EqualTo(-5));
    }

    [Test]
    public void TestAddPositiveDecimalNumbers()
    {
        var calc = new Calc(3.5, 2.7, '+');
        Assert.That(calc.Calculate(), Is.EqualTo(6.2).Within(0.0001));
    }

    [Test]
    public void TestAddNegativeDecimalNumbers()
    {
        var calc = new Calc(-5.4, -2.7, '+');
        Assert.That(calc.Calculate(), Is.EqualTo(-8.1).Within(0.0001));
    }

    [Test]
    public void TestAddDifferentSignsDecimalNumbers()
    {
        var calc = new Calc(-5.4, 2.4, '+');
        Assert.That(calc.Calculate(), Is.EqualTo(-3).Within(0.0001));
    }

    [Test]
    public void TestAddPositiveDecimalNumberAndZero()
    {
        var calc = new Calc(2.4, 0, '+');
        Assert.That(calc.Calculate(), Is.EqualTo(2.4).Within(0.0001));
    }

    [Test]
    public void TestAddNegativeDecimalNumberAndZero()
    {
        var calc = new Calc(-2.8, 0, '+');
        Assert.That(calc.Calculate(), Is.EqualTo(-2.8).Within(0.0001));
    }
}