using System;

class Program
{
    static int CalculateFactorial(int n)
    {
        int Factorial(int number)
        {
            if (number <= 1)
                return 1;
            return number * Factorial(number - 1);
        }

        return Factorial(n);
    }

    static void Main()
    {
        Console.Write("Enter number for factorial: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Factorial of {num} is {CalculateFactorial(num)}");
    }
}
