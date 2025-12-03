using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity r1 = new RunningActivity("03 Dec 2025",30,"Running",3);
        RunningActivity r2 = new RunningActivity("11 Dec 2025",60,"Running",4);
        BicycleActivity b1 = new BicycleActivity("03 Dec 2025",15,"Bicycle",12);
        BicycleActivity b2 = new BicycleActivity("11 Dec 2025",45,"Bicycle",8);
        SwimmingActivity s1 = new SwimmingActivity("03 Dec 2025",30,"Swimming",8);
        SwimmingActivity s2 = new SwimmingActivity("11 Dec 2025",15,"Swimming",6);

        Console.WriteLine("\nRunning Information: ");
        Console.WriteLine($"{r1.GetSummary()}");
        Console.WriteLine($"{r2.GetSummary()}\n");
        Console.WriteLine("Bicycle Information: ");
        Console.WriteLine($"{b1.GetSummary()}");
        Console.WriteLine($"{b2.GetSummary()}\n");
        Console.WriteLine("Swimming Information: ");
        Console.WriteLine($"{s1.GetSummary()}");
        Console.WriteLine($"{s2.GetSummary()}\n");
    }
}