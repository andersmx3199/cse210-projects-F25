class Product
{
    // Attributes for the Product Class
    private string _itemName = "";
    private string _productID = "";
    private decimal _price = 0;
    private int _quantity = 0;

    // Behaviors for the Product Class
    // Product constructor
    public Product (string itemName, string productID, decimal price, int quantity)
    {
        _itemName = itemName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public decimal GetTotal()
    {
        return _price * _quantity;
    }

    public string GetItemName()
    {
        return _itemName;
    }
    public string GetProductID()
    {
        return _productID;
    }
}