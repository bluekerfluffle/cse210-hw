namespace Till;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Till!");

        Bin mybin = new("quarters", 40, (float) 0.25);
        mybin.ModifyAmount(+6);
        Console.WriteLine (mybin.TotalValue());
    }
}
