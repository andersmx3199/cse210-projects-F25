using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Shape World!");

        List<shape> shapes = new List<shape>();

        square shape1 = new square("Green", 6);
        shapes.Add(shape1);

        rectangle shape2 = new rectangle("Black", 9, 3);
        shapes.Add(shape2);

        circle shape3 = new circle("Yellow", 4);
        shapes.Add(shape3);

        foreach (shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"{color} shape -- Area: {area}");
        }
    }
}