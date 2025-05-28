#nullable enable
using System;

class Person
{
    public string? Name { get; set; }
    public string? Email { get; set; }
}

class Program
{
    static void Main()
    {
        Person? p = null;

        // Null-conditional operator
        Console.WriteLine(p?.Name ?? "Name not available");

        p = new Person { Name = null, Email = "example@mail.com" };
        Console.WriteLine(p.Name ?? "Name is null");
        Console.WriteLine(p.Email ?? "Email is null");
    }
}
