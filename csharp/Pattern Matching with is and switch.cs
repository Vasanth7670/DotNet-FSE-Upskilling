using System;

class Program
{
    static void PrintInfo(object obj)
    {
        if (obj is int i)
            Console.WriteLine($"Integer: {i}");
        else if (obj is string s)
            Console.WriteLine($"String: {s}");
        else
            Console.WriteLine("Unknown type");

        // Enhanced switch
        string result = obj switch
        {
            int num => $"Switch: It's an integer {num}",
            string str => $"Switch: It's a string \"{str}\"",
            _ => "Switch: Unknown type"
        };

        Console.WriteLine(result);
    }

    static void Main()
    {
        PrintInfo(42);
        PrintInfo("Hello");
        PrintInfo(3.14);
    }
}
