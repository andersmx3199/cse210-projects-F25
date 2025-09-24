using System;

class Program
{
    static void Main(string[] args)
    {
        // Name and square favorite number function
        void NameAndSquareNum(string param1, int param2)
        {
            int squareNum = param2 * param2;
            Console.WriteLine($"{param1}, the square of your number is: {squareNum}");
        }

        // Age function
        void AgeCalculator(string name, int param3)
        {
            int age = 2025 - param3;
            Console.WriteLine($"{name}, you turn {age} this year.");
        }

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

        NameAndSquareNum(userName, userNum);
        AgeCalculator(userName, userYear);
    }
}