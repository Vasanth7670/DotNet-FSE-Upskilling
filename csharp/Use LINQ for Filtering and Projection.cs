using System;
using System.Collections.Generic;
using System.Linq;

class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public double TotalAmount { get; set; }
}

class Program
{
    static void Main()
    {
        var orders = new List<Order>
        {
            new Order { OrderId = 1, CustomerName = "John", TotalAmount = 500 },
            new Order { OrderId = 2, CustomerName = "Alice", TotalAmount = 1200 },
            new Order { OrderId = 3, CustomerName = "Bob", TotalAmount = 300 }
        };

        var filtered = from order in orders
                       where order.TotalAmount > 400
                       select new { order.CustomerName, order.TotalAmount };

        Console.WriteLine("Orders with amount > 400:");
        foreach (var item in filtered)
            Console.WriteLine($"Name: {item.CustomerName}, Amount: {item.TotalAmount}");
    }
}
