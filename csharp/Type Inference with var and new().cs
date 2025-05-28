using System;

class Custom { public string Info = "Custom Class"; }

class Program
{
    static void Main()
    {
        var number = 5;
        var text = "Hello";
        var obj = new Custom();
        Custom obj2 = new();

        Console.WriteLine($"number: {number.GetType()}, value: {number}");
        Console.WriteLine($"text: {text.GetType()}, value: {text}");
        Console.WriteLine($"obj: {obj.GetType()}, info: {obj.Info}");
        Console.WriteLine($"obj2: {obj2.GetType()}, info: {obj2.Info}");
    }
}
