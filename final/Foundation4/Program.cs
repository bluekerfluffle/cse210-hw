using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activitiesList = new List<Activity>();

        Running running = new Running(20, 4);
        activitiesList.Add(running);
        Cycling cycling = new Cycling(50, 15);
        activitiesList.Add(cycling);
        Swimming swimming = new Swimming(45, 25);
        activitiesList.Add(swimming);

        foreach (Activity activity in activitiesList)
        {
            activity.DisplaySummary();
        }
    }
}