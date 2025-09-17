using System;

class Program
{
    static void Main(string[] args)
    {
        // Core 1, have the user provide a magic number.

        //Console.Write("What is the magic number? ");
        //string num = Console.ReadLine();
        //int magicNum = int.Parse(num);

        // Core 3, magic number generator
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 100);

        int userGuess = 0;

        // Console.Write("What is your guess? ");
        //     string guess = Console.ReadLine();
        //     int userGuess = int.Parse(guess);


        // While Loop (while the userGuess != magicNum continue the loop.)
        while (userGuess != magicNum)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            userGuess = int.Parse(guess);

            if (userGuess < magicNum)
            {
                Console.WriteLine("Higher.");
            }
            else if (userGuess > magicNum)
            {
                Console.WriteLine("Lower.");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

        //Console.WriteLine("You guessed it!");
    }
}