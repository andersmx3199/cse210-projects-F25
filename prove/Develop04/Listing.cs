class Listing : CountAndSpin
{
    private List<string> _prompts = new List<string>
    {
        "Name people who have helped you recently.",
        "List things you enjoy about your life.",
        "What moments this month made you smile?",
        "Who do you feel grateful for today?",
        "What personal strengths have helped you this week?"
    };

    public Listing()
    {
        _name = "Listing";
        _description = "Write down as many thoughts as you can related to a given topic.";
    }

    public override void Run()
    {
        StartActivity();

        var rnd = new Random();
        Console.WriteLine("\nWrite as many answers as you can for:");
        Console.WriteLine($"\n{_prompts[rnd.Next(_prompts.Count)]}");

        Console.Write("Starting in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();

        List<string> responses = new();
        DateTime stop = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < stop)
        {
            Console.Write("> ");
            responses.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {responses.Count} items.");
        EndActivity();
    }
}
