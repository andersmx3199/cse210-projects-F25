class Breathe : CountAndSpin
{
    public Breathe()
    {
        _name = "Breathe";
        _description = "Follow a slow inhale and exhale pattern to calm your body and mind.";
    }

    public override void Run()
    {
        StartActivity();

        Console.WriteLine("Your time will be adjusted (when not divisible by 4) to complete the program.");

        int inOut = _duration;
        for (int i = 0; i < inOut;)
        {
            Console.WriteLine("");
            Console.WriteLine("Inhale...");
            ShowCountdown(4);
            i = i + 4;
            Console.WriteLine($"Total time: {i}");
            Console.WriteLine("Exhale...");
            ShowCountdown(4);
            i = i + 4;
            Console.WriteLine($"Total time: {i} seconds.");
        }

        EndActivity();
    }
}
