public class EternalGoal : Goal
{
    private int _timesCompleted;

    public EternalGoal(string name, string description, int score, int timesCompleted)
        : base(name, description, score)
    {
        _timesCompleted = timesCompleted;
    }

    public override int RecordEvent()
    {
        _timesCompleted += 1;
        return GetScore();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string ReturnGoal()
    {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetScore()}";
    }
}
