class Reflect : CountAndSpin
{
    private List<string> _prompts = new List<string>
    {
        "Think of a moment when you helped someone.",
        "Recall a time you overcame something hard.",
        "Remember a time you supported a friend.",
        "Think of a moment you acted with kindness."
    };

    private List<string> _questions = new List<string>
    {
        "Why did this matter to you?",
        "What did you learn from it?",
        "How did it begin?",
        "How did you feel after?",
        "What made it meaningful?",
        "What stands out the most?",
        "How can this help you later?",
        "What does this say about you?",
        "How could you use this strength again?"
    };

    public Reflect()
    {
        _name = "Reflect";
        _description = "Look back on a moment of strength to better understand yourself.";
    }

    public override void Run()
    {
        StartActivity();

        var rnd = new Random();
        Console.WriteLine("\nThink about this prompt:");
        Console.WriteLine($"\n{_prompts[rnd.Next(_prompts.Count)]}");
        Console.WriteLine("\nPress enter when ready.");
        Console.ReadLine();

        Console.Write("Starting in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();

        DateTime until = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < until)
        {
            Console.WriteLine($"\n{_questions[rnd.Next(_questions.Count)]}");
            ShowSpinner(5);
        }

        EndActivity();
    }
}
