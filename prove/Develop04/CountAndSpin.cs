abstract class CountAndSpin
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name}");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nSet duration (seconds): ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("\nNice job.");
        ShowSpinner(2);
        Console.WriteLine($"\nYou spent {_duration} seconds doing {_name}.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int sec)
    {
        string[] spin = { "|", "/", "-", "\\" };
        int total = sec * 4;
        for (int i = 0; i < total; i++)
        {
            Console.Write($"\r{spin[i % 4]}");
            Thread.Sleep(250);
        }
        Console.Write("\r ");
    }

    protected void ShowCountdown(int sec)
    {
        for (int i = sec; i > 0; i--)
        {
            Console.Write($"\r{i} ");
            Thread.Sleep(1000);
        }
        Console.Write("\r  ");
    }

    public abstract void Run();
}
