using System;

    public class Entry
    {
        // Private fields
        private string _prompt;
        private string _response;
        private string _entryDate;

        // Constructor
        public Entry(string prompt, string response, string date)
        {
            _prompt = prompt;
            _response = response;
            _entryDate = date;
        }

        // Accessor methods
        public string GetPrompt()
        {
            return _prompt;
        }

        public string GetResponse()
        {
            return _response;
        }

        public string GetDate()
        {
            return _entryDate;
        }

        // Mutator methods
        public void SetPrompt(string prompt)
        {
            _prompt = prompt;
        }

        public void SetResponse(string response)
        {
            _response = response;
        }

        public void SetDate(string date)
        {
            _entryDate = date;
        }

        // Display nicely for console
        public string DisplayEntry()
        {
            return $"Entry Date: {_entryDate}\nPrompt Question: {_prompt}\nYour Response: {_response}\n";
        }

        // Format for file saving
        public string FormatForFile()
        {
            return $"{_prompt}|{_response}|{_entryDate}";
        }
    }

