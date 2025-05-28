using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter score (0–100): ");
        int score = int.Parse(Console.ReadLine());

        string grade = score switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            < 60 => "F",
            _ => "Invalid"
        };

        Console.WriteLine($"Grade: {grade}");
    }
}
