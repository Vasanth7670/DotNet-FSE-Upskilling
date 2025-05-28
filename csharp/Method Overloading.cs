using System;

class Calculator
{
    public int CalculateTotal(int a, int b)
    {
        return a + b;
    }

    public double CalculateTotal(double a, double b, double c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        int sum1 = calc.CalculateTotal(10, 20);
        double sum2 = calc.CalculateTotal(1.5, 2.5, 3.5);

        Console.WriteLine($"Sum (int): {sum1}");
        Console.WriteLine($"Sum (double): {sum2}");
    }
}
