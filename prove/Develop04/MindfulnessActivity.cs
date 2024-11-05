using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    private string _name;
    private string _description;
    private int _duration;

    public void SetActivityDetails(string activity_name, string activity_description)
    {
        _name = activity_name;
        _description = activity_description;
    }

    public void Start()
    {
        Console.WriteLine($"Starting: {_name}");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Pause();
    }

    public void End()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You completed the {_name} activity for {_duration} seconds.");
        Pause();
    }

    public void Pause()
    {
        string spinner = "|/-\\";
        for (int i = 0; i < 10; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(200);
            Console.Write("\b");  // Use \b without WriteLine for spinner animation
        }
        Console.WriteLine();
    }

    protected int GetDuration()
    {
        return _duration;
    }

    public abstract void RunActivity();
}
