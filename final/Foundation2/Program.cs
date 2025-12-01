using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("987 Firehouse Rd.", "Greenville", "NY", "USA");
        Customer c1 = new Customer("Billy Bob", a1, true);
        Order order1 = new Order(c1);
        order1.AddProduct(new Product("Smoke Alarm", "Fire101", 11.99m, 3));
        order1.AddProduct(new Product("Fire Extinguisher", "Fire102", 26.99m, 3));

        Address a2 = new Address("Lindvagen 6425", "Stockholm","", "Sweden");
        Customer c2 = new Customer("Leinna Bergstrom", a2, false);
        Order order2 = new Order(c2);
        order2.AddProduct(new Product("Nutella", "Food1205", 3.79m, 10));
        order2.AddProduct(new Product("Guitar", "Music142", 199.99m, 1));

        Console.WriteLine(order1.GetOrderLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Overall Cost: {order1.OverallCost()}");
        Console.WriteLine("");
        Console.WriteLine(order2.GetOrderLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Overall Cost: {order2.OverallCost()}");
        Console.WriteLine("");
    }
}