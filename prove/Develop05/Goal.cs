public abstract class Goal
{
    private int _totalScore;
    private string _name;
    private string _description;

    public Goal(string name, string description, int score)
    {
        _name = name;
        _description = description;
        _totalScore = score;
    }

    public abstract int RecordEvent();

    public virtual void DisplayGoal()
    {
        if (IsComplete())
        {
            Console.WriteLine($"[X] {GetName()} ({GetDescription()})");
        }
        else
        {
            Console.WriteLine($"[ ] {GetName()} ({GetDescription()})");
        }
    }

    public abstract bool IsComplete();

    public abstract string ReturnGoal();

    public int GetScore()
    {
        return _totalScore;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetName()
    {
        return _name;
    }
}
