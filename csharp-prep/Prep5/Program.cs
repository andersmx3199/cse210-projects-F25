using System;

class Program
{
    static void Main(string[] args)
    {
        // Program welcome
        Console.WriteLine("Welcome to the program! ");

        // Enter name to put into name function
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        // Enter favorite number to put into number function
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int userNum = int.Parse(number);

        // Enter birth year for function
        Console.Write("Please enter the year you were born: ");
        string year = Console.ReadLine();
        int userYear = int.Parse(year);
    }
}