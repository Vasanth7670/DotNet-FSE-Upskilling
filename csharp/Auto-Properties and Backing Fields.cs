using System;

class Product
{
    public string Name { get; set; }

    private decimal _price;
    public decimal Price
    {
        get => _price;
        set
        {
            if (value < 0)
                Console.WriteLine("Price cannot be negative.");
            else
                _price = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Product p = new Product();
        p.Name = "Laptop";
        p.Price = 1500;

        Console.WriteLine($"Name: {p.Name}, Price: {p.Price}");

        p.Price = -100; // should trigger validation
    }
}
