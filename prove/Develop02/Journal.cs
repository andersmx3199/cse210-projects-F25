using System;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Add a new journal entry
    public void AddEntry()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your thoughts: ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry(prompt, response, DateTime.Now.ToString("yyyy-MM-dd"));
        _entries.Add(newEntry);

        Console.WriteLine("Entry added!\n");
    }

    // Display all entries
    public void ShowAllEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.\n");
            return;
        }

        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.DisplayEntry());
        }
    }

    // Save journal to a file in the current directory
    public void SaveToFile()
    {
        Console.Write("Enter file name (without extension): ");
        string fileNameBase = Console.ReadLine();

        string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
        string fileName = $"{fileNameBase}_{timestamp}.txt";

        string fullPath = Path.Combine(Environment.CurrentDirectory, fileName);

        using (StreamWriter writer = new StreamWriter(fullPath))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.FormatForFile());
            }
        }

        Console.WriteLine($"Journal saved as: {fileName}");
        Console.WriteLine($"Location: {Environment.CurrentDirectory}\n");
    }

    // Load journal from file in the current directory
    public void LoadFromFile()
    {
        Console.Write("Enter file name to load (include .txt): ");
        string fileName = Console.ReadLine();

        string fullPath = Path.Combine(Environment.CurrentDirectory, fileName);

        if (!File.Exists(fullPath))
        {
            Console.WriteLine("File not found!\n");
            return;
        }

        _entries.Clear();

        foreach (string line in File.ReadAllLines(fullPath))
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                _entries.Add(new Entry(parts[0], parts[1], parts[2]));
            }
        }

        Console.WriteLine("Journal loaded successfully.\n");
    }

    // Random journal prompt
    private string GetRandomPrompt()
    {
        string[] prompts =
        {
            "What made you smile today?",
            "What challenge did you overcome?",
            "How did you grow today?",
            "What are you most thankful for?",
            "Describe a meaningful moment from today."
        };

        Random rnd = new Random();
        return prompts[rnd.Next(prompts.Length)];
    }
}
