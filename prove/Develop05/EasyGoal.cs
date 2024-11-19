public class EasyGoal : Goal
{
    private bool _completed;

    public EasyGoal(string name, string description, int score, bool completed)
        : base(name, description, score)
    {
        _completed = completed;
    }

    public override int RecordEvent()
    {
        _completed = true;
        return GetScore();
    }

    public override bool IsComplete()
    {
        return _completed;
    }

    public override string ReturnGoal()
    {
        return $"EasyGoal:{GetName()},{GetDescription()},{GetScore()},{IsComplete()}";
    }
}
