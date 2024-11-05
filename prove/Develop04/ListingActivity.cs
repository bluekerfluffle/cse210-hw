public class ListingActivity : MindfulnessActivity
{
    private static readonly string[] _prompting = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt grateful this month?",
        "Who are some of your personal heroes?"
    };

    private static readonly Random _random = new Random();

    public ListingActivity()
    {
        SetActivityDetails("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public override void RunActivity()
    {
        Start();
        Console.WriteLine(_prompting[_random.Next(_prompting.Length)]);
        Pause();

        int itemCount = 0;
        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.Write("Enter an item: ");
            Console.ReadLine();
            itemCount++;
            elapsed += 5; // Assuming each entry takes roughly 5 seconds
            Pause();
        }

        Console.WriteLine($"You listed {itemCount} items.");
        End();
    }
}
