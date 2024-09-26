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

        int sum = 0;
        int max = numberList[0];

        foreach (int item in numberList)
        {
            sum += item;
            

            if (item > max)
            {
                max = item;
            }
        }

        int count = numberList.Count;
        double average = (double)sum /count;

        Console.WriteLine($"The sum is {sum}.");
        Console.WriteLine($"The average is {average}.");
        Console.WriteLine($"The largest number is {max}.");
    }
}