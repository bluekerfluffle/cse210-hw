using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList;
        numberList = new();

        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int input = -1;

        while(input != 0)
        {
            Console.Write("Enter Number:");
            string inputString = Console.ReadLine();
            input = int.Parse(inputString);
            if(input != 0)
            {
                numberList.Add(input);
            }
        }

        int i = 0;

        foreach (int item in numberList)
        {
            
        }

    }
}