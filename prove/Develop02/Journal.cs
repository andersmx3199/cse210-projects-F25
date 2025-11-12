using System;
using System.Collections.Generic;
using System.IO;


    public class Journal
    {
        private List<Entry> _entries;

        public Journal()
        {
            _entries = new List<Entry>();
        }

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

        public void ShowAllEntries()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("Your journal is empty.");
                return;
            }

            foreach (Entry i in _entries)
            {
                Console.WriteLine(i.DisplayEntry());
            }
        }

        public void SaveToFile()
        {
            Console.Write("Enter filename base: ");
            string baseName = Console.ReadLine();
            string folderPath = @"C:\Users\ander\Documents\Fall 2025\210 - Prog w Classes\cse210-projects-F25\prove\Develop02\";
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string fullPath = Path.Combine(folderPath, $"{baseName}_{timestamp}.txt");

            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                foreach (Entry i in _entries)
                {
                    writer.WriteLine(i.FormatForFile());
                }
            }

            Console.WriteLine($"Journal saved successfully at {fullPath}");
        }

        public void LoadFromFile()
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            if (!File.Exists(path))
            {
                Console.WriteLine("File not found!");
                return;
            }

            _entries.Clear();

            foreach (string line in File.ReadAllLines(path))
            {
                string[] parts = line.Split(' ');
                if (parts.Length == 3)
                {
                    _entries.Add(new Entry(parts[0], parts[1], parts[2]));
                }
            }

            Console.WriteLine("Journal loaded successfully.\n");
        }

        private string GetRandomPrompt()
        {
            string[] prompts = new string[]
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

