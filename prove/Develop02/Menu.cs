using System;

class Menu
{
    static void Main(string[] args)
    {
        int menuChoice = 0;

        while (menuChoice != 5)
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            // Get the number
            string choice = Console.ReadLine();
            menuChoice = int.Parse(choice);

            if (menuChoice == 1)
            {
                Console.WriteLine("Here is a prompt for you to respond to:");
                PromptGen newPrompt = new PromptGen();
                newPrompt.PickandDisplayPrompt();
            }
            else if (menuChoice == 2)
            {
                Console.WriteLine("2. Display");
            }
            else if (menuChoice == 3)
            {
                Console.WriteLine("3. Load");
            }
            else if (menuChoice == 4)
            {
                Console.WriteLine("4. Save");
            }
            else if (menuChoice != 5)
            {
                Console.WriteLine("Invalid choice, try again");
            }
        }

        Console.WriteLine("Thank you for using the journal program!");
    }
}
