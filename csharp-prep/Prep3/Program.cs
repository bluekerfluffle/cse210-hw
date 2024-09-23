using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Console.Write("What is the magic number?");

        string userMagic = Console.ReadLine();
        int magic = int.Parse(userMagic);

        Console.Write("What is your guess?");
        string userGuess = Console.ReadLine();
        int guess = int.Parse(userGuess);

        while (guess != magic)
        {
            if (guess >= magic)
            {
                Console.WriteLine("Higher");
            }
            else if (guess <= magic)
            {
                Console.WriteLine("Lower");
            }
        }
        
        if (guess == magic)
        {
            Console.WriteLine("You guessed it!");
        }
    }
}