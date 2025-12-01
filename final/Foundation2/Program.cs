using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("HOUSENUM", "CITY", "STATE", "COUNTRY");
        Customer c1 = new Customer("CUSTNAME", a1, true);
        Order order1 = new Order(c1);
        order1.AddProduct(new Product("ITEMNAME", "PRODID", 1.99m, 1));
        order1.AddProduct(new Product("ITEM2", "ITEMID2", 2.99m, 3));

        Address a2 = new Address("House2", "City2", "State2", "Country2");
        Customer c2 = new Customer("Name2", a2, false);
        Order order2 = new Order(c2);
        order2.AddProduct(new Product("Item1", "ID1", 1.79m, 10));
        order2.AddProduct(new Product("Item2", "ID2", 3, 6));

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