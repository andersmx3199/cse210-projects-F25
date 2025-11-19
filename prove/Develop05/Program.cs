using System;

class Program
{
    static void Main(string[] args)
    {

            bool running = true;
            while (running){
                Console.WriteLine("");
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");

                Console.Write("Select an option (1-6): ");
                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("");
                        //myJournal.AddEntry(); -- call the created goal to enter a new goal
                        break;

                    case "2":
                        Console.WriteLine("");
                        //myJournal.ShowAllEntries(); -- care the created goal to share the goals method
                        break;

                    case "3":
                        Console.WriteLine("");
                        //myJournal.SaveToFile(); -- call created goal and save to a file
                        break;

                    case "4":
                        Console.WriteLine("");
                        //myJournal.LoadFromFile(); 
                        break;
                    
                    case "5":
                        Console.WriteLine("");
                        break;

                    case "6":
                        running = false;
                        Console.WriteLine("Exiting program. Goodbye!");
                        Console.WriteLine("");
                        break;

                    default:
                        Console.WriteLine("Invalid selection. Please choose 1-6.");
                        break;
                }
            }
    }
}