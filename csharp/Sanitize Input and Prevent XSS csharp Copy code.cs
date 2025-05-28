using System;
using System.Net;

class Program
{
    static void Main()
    {
        Console.Write("Enter input: ");
        string userInput = Console.ReadLine();

        string safeInput = WebUtility.HtmlEncode(userInput);

        Console.WriteLine($"Sanitized output: {safeInput}");
    }
}
