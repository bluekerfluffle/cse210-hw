using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Journal
{
    public List<JournalEntry> _journal = new List<JournalEntry>();
    public string _userFileName;
    public string newEntry;

    public Journal()
    {
    }

    public void Display()
    {
        Console.WriteLine("########### Journal Entries ###########");
        foreach (JournalEntry journalEntry in _journal)
        {
            journalEntry.Display();
        }
        Console.WriteLine("############ END #############");
    }

    public void CreateJournalFile()
    {
        Console.Write("What is your file name? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (!File.Exists(_userFileName))
        {
            using (File.CreateText(_userFileName)) { } 
            Console.WriteLine($"{_userFileName} has been created! ");
        }
        else
        {
            Console.WriteLine($"{_userFileName} already exists. ");
        }
    }

    public void SaveJournalEntries()
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName))
        {
            foreach (JournalEntry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._entryNumber}; {journalEntry._dateTime}; {journalEntry._journalPrompt}; {journalEntry._journalEntry}");
            }
        }
        Console.WriteLine(" Journal entries have been saved ");
    }

    public void AddJournalEntry(JournalEntry newEntry)
    {
        _journal.Add(newEntry); 
        using (StreamWriter outputFile = new StreamWriter(_userFileName, append: true))
        {
            outputFile.WriteLine($"{newEntry._entryNumber}; {newEntry._dateTime}; {newEntry._journalPrompt}; {newEntry._journalEntry}");
        }
        Console.WriteLine(" New journal entry has been added ");
    }

    public void LoadJournalEntries()
    {
        if (File.Exists(_userFileName))
        {
            string[] readText = File.ReadAllLines(_userFileName); 

            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");
                JournalEntry entry = new JournalEntry
                {
                    _entryNumber = entries[0],
                    _dateTime = entries[1],
                    _journalPrompt = entries[2],
                    _journalEntry = entries[3]
                };
                _journal.Add(entry); 
            }
            Console.WriteLine(" Journal entries have been loaded from file ");
        }
        else
        {
            Console.WriteLine(" File does not exist. Please create a new journal file. ");
        }
    }
}
