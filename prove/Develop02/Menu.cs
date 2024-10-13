using System;

public class Menu
{
    public static int Choices()
    {
        Console.WriteLine("Select an action:");
        Console.WriteLine("1. Write a journal entry");
        Console.WriteLine("2. Display journal entries");
        Console.WriteLine("3. Load journal entries from file");
        Console.WriteLine("4. Save journal file");
        Console.WriteLine("5. Quit");

        string userInput = Console.ReadLine();
        if (int.TryParse(userInput, out int action) && action >= 1 && action <= 5)
        {
            return action;
        }

        return 0;
    }
}
