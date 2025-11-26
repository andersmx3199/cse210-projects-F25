class Reflect : CountSpinBase
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need",
        "Think of a time when you did something truly selfless"
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaning to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is yout favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflect()
    {
        _activityName = "Reflect";
        _descriptionOfActivity = "Look back on a moment of strength to better understand yourself.";
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
