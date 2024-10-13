using System; 
class Program
{   
    public static Journal journal = new Journal();
    static void Main(string[] args)
    {
        Console.Write("Welcome to your Journal!");

        JournalEntry entry = null;
        JournalEntry jp = new JournalEntry();
        int action = -1;

        while (action != 5)
        {
            action = Menu.Choices();

            switch (action)
            {
                case 1:
                    journal.CreateJournalFile();
                    
                    string entryId = GenerateEntryId();
                    string dateInfo = GetDateTime();
                    string prompt = jp.GetPrompt();

                    entry = new JournalEntry
                    {
                        _entryNumber = entryId,
                        _dateTime = dateInfo,
                        _journalPrompt = prompt
                    };

                    Console.WriteLine(prompt);
                    string userResponse = Console.ReadLine();
                    entry._journalEntry = userResponse;
                    journal.AddJournalEntry(entry);


                    break;

                case 2:
                    journal.Display();
                    break;

                case 3:
                    journal.LoadJournalEntries();
                    break;

                case 4:
                
                    if (entry!=null)
                    {
                        journal.AddJournalEntry(entry);
                    }
                    else
                    {
                        Console.WriteLine("No entry available to add.");
                    }
                    break;
                    
                case 5:
                    Console.WriteLine("Thank you for using your Journal!");
                    break;

                default:
                    Console.WriteLine($"Sorry, the option you entered is not valid");
                    break;
            }
        }
    }

    static string GetDateTime()
    {
        return DateTime.Now.ToString("F");
    }

    static string GenerateEntryId()
    {
        return Guid.NewGuid().ToString();
    }
}
