using System;

class Program
{
    static void Main(string[] args)
    {
        List<CountSpinBase> activities = new List<CountSpinBase>
        {
            new Breathe(),
            new Reflect(),
            new Listing()
        };

        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start beathe activity");
            Console.WriteLine("2. Start reflect activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    activities[0].Run();
                    break;
                case "2":
                    activities[1].Run();
                    break;
                case "3":
                    activities[2].Run();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
