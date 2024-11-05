public class ReflectionActivity : MindfulnessActivity
{
    private static readonly string[] Prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly string[] Questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };

    private static readonly Random Random = new Random();

    public ReflectionActivity()
    {
        SetActivityDetails("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.");
    }

    public override void RunActivity()
    {
        Start();
        Console.WriteLine(Prompts[Random.Next(Prompts.Length)]);
        Pause();

        for (int i = 0; i < GetDuration(); i += 4)
        {
            Console.WriteLine(Questions[Random.Next(Questions.Length)]);
            Pause();
        }
        End();
    }
}

