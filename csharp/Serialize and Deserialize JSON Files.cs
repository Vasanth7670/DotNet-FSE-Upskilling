using System;
using System.IO;
using System.Text.Json;

class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main()
    {
        var user = new User { Name = "Ravi", Age = 25, Email = "ravi@example.com" };

        string json = JsonSerializer.Serialize(user);
        File.WriteAllText("user.json", json);
        Console.WriteLine("Serialized to user.json");

        string readJson = File.ReadAllText("user.json");
        var deserialized = JsonSerializer.Deserialize<User>(readJson);

        Console.WriteLine($"Name: {deserialized.Name}, Age: {deserialized.Age}, Email: {deserialized.Email}");
    }
}
