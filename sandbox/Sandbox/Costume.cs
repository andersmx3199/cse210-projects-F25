class Costume
{
    // attributes
    string body = ""; // Empty string
    string size = "";
    string footwear = "";
    string tools = "";

    // behaviors

    void Display()
    {
        Console.WriteLine($"Body clothes: {body}, size: {size}");
        Console.WriteLine($"Footwear: {footwear}");
        Console.WriteLine($"Accessories: {tools}");
    }
}