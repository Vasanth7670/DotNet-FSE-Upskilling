#nullable enable
using System;

class Contact
{
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }
}

class Program
{
    static void Main()
    {
        Contact? contact = null;

        Console.WriteLine($"Contact name: {contact?.Name ?? "Unknown"}");

        contact = new Contact { Name = null, PhoneNumber = "1234567890" };
        Console.WriteLine($"Contact name: {contact?.Name ?? "No name provided"}");

        contact.Name = "Alice";
        Console.WriteLine($"Contact name: {contact?.Name}");
    }
}
