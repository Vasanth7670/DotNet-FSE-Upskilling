using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
        Dictionary<int, string> students = new Dictionary<int, string>
        {
            { 1, "Ravi" },
            { 2, "Sita" },
            { 3, "Lakshmi" }
        };

        Console.WriteLine("Fruits:");
        foreach (var fruit in fruits)
            Console.WriteLine(fruit);

        Console.WriteLine("\nStudents:");
        foreach (var kvp in students)
            Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");

        // Add and Remove
        fruits.Add("Mango");
        fruits.Remove("Banana");
        students.Remove(2);

        Console.WriteLine("\nAfter Modifications:");
        foreach (var fruit in fruits)
            Console.WriteLine(fruit);
        foreach (var kvp in students)
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }
}
