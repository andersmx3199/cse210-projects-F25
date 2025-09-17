using System;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        char letter;

        Console.Write("Hello, please provide your grade percentage: ");
        string number = Console.ReadLine();
        int percent = int.Parse(number);

        if (percent >= 90)
        {
            //Console.WriteLine("Your letter grade is an A.");
            letter = 'A';
        }

        else if (percent >= 80 && percent < 90)
        {
            //Console.WriteLine("Your letter grade is a B.");
            letter = 'B';
        }

        else if (percent >= 70 && percent < 80)
        {
            //Console.WriteLine("Your letter grade is a C.");
            letter = 'C';
        }

        else if (percent >= 60 && percent < 70)
        {
            //Console.WriteLine("YOur letter grade is a D.");
            letter = 'D';
        }

        else
        {
            //Console.WriteLine("Your letter grade is an F.");
            letter = 'F';
        }


        // Core 3, present letter grade
        Console.WriteLine($"Your letter grade is a[n] {letter}.");

        // Pass the class or not
        if (percent >= 70)
        {
            Console.WriteLine("Congrats! You passes the class!");
        }
        else
        {
            Console.WriteLine("You did not pass. Better luck next time!");
        }
    }
}