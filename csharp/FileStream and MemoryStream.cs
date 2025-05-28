using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        // FileStream
        string path = "test.txt";
        File.WriteAllText(path, "Hello from FileStream!");
        using FileStream fs = new FileStream(path, FileMode.Open);
        using StreamReader reader = new StreamReader(fs);
        Console.WriteLine("File content: " + reader.ReadToEnd());

        // MemoryStream
        byte[] buffer;
        using (MemoryStream ms = new MemoryStream())
        {
            byte[] data = Encoding.UTF8.GetBytes("Hello MemoryStream");
            ms.Write(data, 0, data.Length);
            buffer = ms.ToArray();
        }
        Console.WriteLine("MemoryStream Bytes Written: " + buffer.Length);
    }
}
