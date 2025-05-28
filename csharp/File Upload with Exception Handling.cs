using System;
using System.Threading.Tasks;

class Program
{
    static async Task<string> UploadFileAsync()
    {
        await Task.Delay(3000); // Simulate delay
        return "Upload successful!";
    }

    static async Task Main()
    {
        try
        {
            Console.WriteLine("Uploading file...");
            string result = await UploadFileAsync();
            Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Upload failed: {ex.Message}");
        }
    }
}
