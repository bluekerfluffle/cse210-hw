using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string userpercent = Console.ReadLine();
        int percent = int.Parse(userpercent);
        string letter;


        if (percent >= 90)
        {
            letter = "A";

            if (percent < 93)
            {
                letter = "A-";
            }
        }
        else if (percent >= 80)
        {
            letter = "B";

            if (percent >=87)
            {
                letter = "B+";
            }

            else if (percent < 83)
            {
                letter = "B-";
            }
        }
        else if (percent >= 70)
        {
            letter = "C";

            if (percent >=77)
            {
                letter = "C+";
            }

            else if (percent < 73)
            {
                letter = "C-";
            }
        }
        else if (percent >= 60)
        {
            letter = "D";

            if (percent >=67)
            {
                letter = "D+";
            }

            else if (percent < 63)
            {
                letter = "D-";
            }
        }
        else 
        {
            letter = "F";
        }

        if (percent >= 70)
        {
            Console.WriteLine("You passed");
        }
        else if (percent <70)
        {
            Console.WriteLine("Try Again Next Time");
        }

        Console.WriteLine($"Your letter grade is an {letter}");
    }
}