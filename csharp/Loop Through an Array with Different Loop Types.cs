using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Using for loop:");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 30) continue;
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("Using foreach loop:");
        foreach (int number in numbers)
        {
            if (number == 30) continue;
            Console.WriteLine(number);
        }

        Console.WriteLine("Using while loop:");
        int j = 0;
        while (j < numbers.Length)
        {
            if (numbers[j] == 30)
            {
                j++;
                continue;
            }
            Console.WriteLine(numbers[j]);
            j++;
        }

        Console.WriteLine("Using do-while loop:");
        int k = 0;
        do
