using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignments assignment1 = new Assignments("Frank Stanley", "Math");
        Console.WriteLine(assignment1.GetAllInfo());

        MathClass assignment2 = new MathClass("Jess Chance", "Division","5.4","1-5");
        Console.WriteLine(assignment2.GetAllInfo());
        Console.WriteLine(assignment2.GetHomework());

        WritingClass assignment3 = new WritingClass("Harold John", "American Lit","Edgar Allen Poe");
        Console.WriteLine(assignment3.GetAllInfo());
        Console.WriteLine(assignment3.GetWritingInfo());
    }
}