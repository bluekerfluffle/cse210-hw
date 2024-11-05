public class ListingActivity : MindfulnessActivity
{
    private static readonly string[] Prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt grateful this month?",
        "Who are some of your personal heroes?"
    };

    private static readonly Random Random = new Random();

    public ListingActivity()
    {
        SetActivityDetails("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public override void RunActivity()
    {
        Start();
        Console.WriteLine(Prompts[Random.Next(Prompts.Length)]);
        Pause();

        int itemCount = 0;
        for (int i = 0; i < GetDuration(); i += 5)
        {
            Console.Write("Enter an item: ");
            Console.ReadLine();
            itemCount++;
        }
        
        Console.WriteLine($"You listed {itemCount} items.");
        End();
    }
}
