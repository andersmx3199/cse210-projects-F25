using System;


    class Program
    {
        static void Main(string[] args)
        {
            Journal myJournal = new Journal();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== My Personal Journal ===");
                Console.WriteLine("1. Add a new entry");
                Console.WriteLine("2. View all entries");
                Console.WriteLine("3. Save journal to file");
                Console.WriteLine("4. Load journal from file");
                Console.WriteLine("5. Quit");

                Console.Write("Select an option (1-5): ");
                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        myJournal.AddEntry();
                        break;

                    case "2":
                        myJournal.ShowAllEntries();
                        break;

                    case "3":
                        myJournal.SaveToFile();
                        break;

                    case "4":
                        myJournal.LoadFromFile();
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid selection. Please choose 1-5.");
                        break;
                }
            }
        }
    }

