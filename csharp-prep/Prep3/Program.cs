using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        int guess = 0;

        do{
            Console.Write("What is your guess?");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
        }while (guess != magic);
        
        
        if (guess == magic)
        {
            Console.WriteLine("You guessed it!");
        }
    }
}