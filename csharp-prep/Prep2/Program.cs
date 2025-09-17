using System;
using System.Diagnostics.Tracing;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, please provide your grade percentage: ");
        string number = Console.ReadLine();

        int percent = int.Parse(number);

        if (percent >= 90)
        {
            Console.WriteLine("Your letter grade is an A.");
        }

        else if (percent >= 80 && percent < 90)
        {
            Console.WriteLine("Your letter grade is a B.");
        }

        else if (percent >= 70 && percent < 80)
        {
            Console.WriteLine("Your letter grade is a C.");
        }

        else if (percent >= 60 && percent < 70)
        {
            Console.WriteLine("YOur letter grade is a D.");
        }

        else if (percent < 60)
        {
            Console.WriteLine("Your letter grade is an F.");
        }

        else
        {
            Console.WriteLine("Invalid percentage.");
        }
    }
}