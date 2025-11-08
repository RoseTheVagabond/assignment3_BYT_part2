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

    [Test]
    public void TestSubtractPositiveNumbers()
    {
        var calc = new Calc(10, 3, '-');
        Assert.That(calc.Calculate(), Is.EqualTo(7));
    }

    [Test]
    public void TestSubtractNegativeNumbers()
    {
        var calc = new Calc(-5, -3, '-');
        Assert.That(calc.Calculate(), Is.EqualTo(-2));
    }

    [Test]
    public void TestSubtractBiggerNumberFromSmaller()
    {
        var calc = new Calc(5, 10, '-');
        Assert.That(calc.Calculate(), Is.EqualTo(-5));
    }

    [Test]
    public void TestSubtractZeroFromAPositiveNumber()
    {
        var calc = new Calc(10, 0, '-');
        Assert.That(calc.Calculate(), Is.EqualTo(10));
    }

    [Test]
    public void TestSubtractZeroFromANegativeNumber()
    {
        var calc = new Calc(-10, 0, '-');
        Assert.That(calc.Calculate(), Is.EqualTo(-10));
    }

    [Test]
    public void TestSubtractPositiveDecimalNumbers()
    {
        var calc = new Calc(10.5, 3.2, '-');
        Assert.That(calc.Calculate(), Is.EqualTo(7.3).Within(0.0001));
    }

    [Test]
    public void TestSubtractNegativeDecimalNumbers()
    {
        var calc = new Calc(-10.5, -3.2, '-');
        Assert.That(calc.Calculate(), Is.EqualTo(-7.3).Within(0.0001));
    }

    [Test]
    public void TestMultiplyPositiveNumbers()
    {
        var calc = new Calc(4, 2, '*');
        Assert.That(calc.Calculate(), Is.EqualTo(8));
    }

    [Test]
    public void TestMultiplyNegativeNumbers()
    {
        var calc = new Calc(-3, -4, '*');
        Assert.That(calc.Calculate(), Is.EqualTo(12));
    }

    [Test]
    public void TestMultiplyMixedSignsNumbers()
    {
        var calc = new Calc(10, -2, '*');
        Assert.That(calc.Calculate(), Is.EqualTo(-20));
    }

    [Test]
    public void TestMultiplyByZero()
    {
        var calc = new Calc(5, 0, '*');
        Assert.That(calc.Calculate(), Is.EqualTo(0));
    }

    [Test]
    public void TestMultiplyPositiveDecimalNumbers()
    {
        var calc = new Calc(2.5, 4.2, '*');
        Assert.That(calc.Calculate(), Is.EqualTo(10.5).Within(0.0001));
    }

    [Test]
    public void TestMultiplyHundredsAndThousands()
    {
        var calc = new Calc(1000, 500, '*');
        Assert.That(calc.Calculate(), Is.EqualTo(500000));
    }

    [Test]
    public void TestDividePositiveNumbers()
    {
        var calc = new Calc(9, 3, '/');
        Assert.That(calc.Calculate(), Is.EqualTo(3));
    }

    [Test]
    public void TestDivideSoResultIsDecimal()
    {
        var calc = new Calc(10, 4, '/');
        Assert.That(calc.Calculate(), Is.EqualTo(2.5));
    }

    [Test]
    public void TestDivideNegativeNumbers()
    {
        var calc = new Calc(-12, -3, '/');
        Assert.That(calc.Calculate(), Is.EqualTo(4));
    }

    [Test]
    public void TestDivideMixedSignsNumbers()
    {
        var calc = new Calc(15, -3, '/');
        Assert.That(calc.Calculate(), Is.EqualTo(-5));
    }

    [Test]
    public void TestDividePositiveDecimalNumbers()
    {
        var calc = new Calc(7.5, 2.5, '/');
        Assert.That(calc.Calculate(), Is.EqualTo(3).Within(0.0001));
    }

    [Test]
    public void TestDivideNegativeDecimalNumbers()
    {
        var calc = new Calc(-7.5, -2.5, '/');
        Assert.That(calc.Calculate(), Is.EqualTo(3).Within(0.0001));
    }

    [Test]
    public void TestDivisionByZero()
    {
        var calc = new Calc(9, 0, '/');
        Assert.That(() => calc.Calculate(), Throws.TypeOf<DivideByZeroException>());
    }

    [Test]
    public void TestInvalidOperator()
    {
        var calc = new Calc(5, 3, '%');
        Assert.That(() => calc.Calculate(), Throws.TypeOf<InvalidOperationException>());
    }
}