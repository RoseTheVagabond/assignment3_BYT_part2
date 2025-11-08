using CalculatorNamespace;

Calculator calc1 = new Calculator(10, 5, '+');
Console.WriteLine($"10 + 5 = {calc1.Calculate()}");

Calculator calc2 = new Calculator(10, 2, '/');
Console.WriteLine($"10 / 0 = {calc2.Calculate()}");