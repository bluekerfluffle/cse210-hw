using System;
using System.Threading;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
    {
        SetActivityDetails(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
        );
    }

    public override void RunActivity()
    {
        Start();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            PerformBreathingCycle(1.0, 3.0);
            
            PerformBreathingCycle(3.0, 1.0);
        }

        End();
    }

    private void PerformBreathingCycle(double startSize, double endSize)
    {
        Console.Clear();

        for (double size = startSize; size <= endSize; size += 0.1)
        {
            Console.WriteLine($"{"".PadLeft((int)(size * 10))} Breathe in");
            Thread.Sleep(100);
        }

        Thread.Sleep(500);

        for (double size = endSize; size >= startSize; size -= 0.1)
        {
            Console.WriteLine($"{"".PadLeft((int)(size * 10))} Breathe Out");
            Thread.Sleep(100);
        }

        Thread.Sleep(500);
    }
}
