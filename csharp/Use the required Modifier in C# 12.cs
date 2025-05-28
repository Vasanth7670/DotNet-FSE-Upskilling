public class Student
{
    public required string Name { get; set; }
    public required int RollNumber { get; set; }
}

class Program
{
    static void Main()
    {
        // Uncommenting the line below without setting required properties will cause a compile-time error.
        // var s = new Student();

        var s = new Student { Name = "Kiran", RollNumber = 123 };
        Console.WriteLine($"Name: {s.Name}, Roll Number: {s.RollNumber}");
    }
}
