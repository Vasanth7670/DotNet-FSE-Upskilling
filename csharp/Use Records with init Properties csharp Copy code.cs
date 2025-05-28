using System;

public record Employee
{
    public string Name { get; init; }
    public int Id { get; init; }
}

class Program
{
    static void Main()
    {
        var emp1 = new Employee { Name = "Alice", Id = 101 };
        var emp2 = emp1 with { Name = "Bob" };

        Console.WriteLine($"Original: {emp1}");
        Console.WriteLine($"Modified Copy: {emp2}");
    }
}
