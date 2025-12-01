class Order
{
    private List<Product> _products;
    private Customer customer;
    private Address address;

    public Order()
    {
        
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal OverallCost()
    {
        decimal total = 0;
        foreach (Product p in _products)
        {
            total = total + p.GetTotal();
        }
        // Returns the total cost of the items and the shipping.
        // to my knowledge, the ? 5 : 35 is the bool function.
        // if USA is true then the cost is 5, if not it is 35. 
        // Had to use AI to help with this section.
        return total + (customer.GetUSA() ? 5 : 35);
    }

    public string GetOrderLabel()
    {
        string label = "Packing Label:";
        Console.WriteLine("");
        foreach (Product p in _products)
        {
            label = label + ($"{p.GetItemName} | {p.GetProductID}");
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return ($"Shipping Label:\n{customer.GetName()}\n{address.GetAddress()}");
    }
}