using System;
using System.Collections.Generic;

public class JournalEntry
{
    public string _entryNumber = "";
    public string _dateTime = "";
    public string _journalPrompt = "";
    public string _journalEntry = "";
    public string UserResponse = "";

    public static string[] _prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "If I had one thing I could do over today, what would it be?",
        "What was the best idea you had today?",
        "List the 3 things you are grateful for today and why.",
        "Who made you feel good today?",
    };

    List<string> _journalPrompts = new List<string>(_prompts);

    public JournalEntry() { }

    public void DisplayPrompt()
    {
        var random = new Random();
        int index = random.Next(_journalPrompts.Count);
        Console.WriteLine($"{_journalPrompts[index]}");
    }

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_journalPrompts.Count);
        return _journalPrompts[index];
    }

    public void Display()
    {
        Console.WriteLine($"#: {_entryNumber}");
        Console.WriteLine($"Date: {_dateTime}");
        Console.WriteLine($"Prompt: {_journalPrompt}");
        Console.WriteLine($"Entry: {_journalEntry}");
    }
}
