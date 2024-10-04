using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "The Church of Jesus Christ of Latter-Day Saints";
        job1._startYear = 2024;
        job1._endYear = 2028;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "The Church of Jesus Christ of Latter-Day Saints";
        job2._startYear = 2020;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Gracie Burris";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
        
    }
}