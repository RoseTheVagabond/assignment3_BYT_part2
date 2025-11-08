namespace CalculatorNamespace;

public class Calculator
{
    public double A { get; }
    public double B { get; }
    public char Operation { get; }

    public Calculator(double a, double b, char operation)
    {
        A = a;
        B = b;
        Operation = operation;
    }

    public double Calculate()
    {
        return Operation switch
        {
            '+' => A + B,
            '-' => A - B,
            '*' => A * B,
            '/' when B != 0 => A / B,
            '/' => throw new DivideByZeroException("Cannot divide by zero."),
            _ => throw new InvalidOperationException($"Invalid operation: {Operation}")
        };
    }
}
