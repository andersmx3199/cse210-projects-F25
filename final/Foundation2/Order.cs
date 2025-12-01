class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
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
        return total + (_customer.GetUSA() ? 5 : 35);
    }

    public string GetOrderLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product p in _products)
        {
            label = label + ($" {p.GetItemName()} | {p.GetProductID()}\n");
            
        }
        return label;
    }

    public string GetShippingLabel()
    {
        Console.WriteLine("");
        return ($"Shipping Label:\n\n{_customer.GetName()}\n{_customer.GetAddress().GetAddress()}");
    }
}