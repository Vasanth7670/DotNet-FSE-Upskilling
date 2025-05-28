using System;

class Program
{
    static (int, string) GetInfo()
    {
        return (1001, "Kiran");
    }

    static void Main()
    {
        var (id, name) = GetInfo();
        Console.WriteLine($"ID: {id}, Name: {name}");
    }
}
