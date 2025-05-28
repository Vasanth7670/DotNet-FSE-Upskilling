using System;

class Program
{
    static void AddRef(ref int x) => x += 10;

    static void InitializeOut(out int x)
    {
        x = 100;
    }

    static void DisplayIn(in int x)
    {
        Console.WriteLine($"Value (in): {x}");
    }

    static void Main()
    {
        int a = 5;
        AddRef(ref a);
        Console.WriteLine($"After ref: {a}");

        InitializeOut(out int b);
        Console.WriteLine($"After out: {b}");

        DisplayIn(in b);
    }
}
