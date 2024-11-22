public class NegativeGoal : Goal
{
    private int _penalty;
    private bool _isCompleted;

    public NegativeGoal(string name, string description, int penalty) : base(name, description, 0)
    {
        _penalty = penalty;
        _isCompleted = false;
    }

    public override int RecordEvent()
    {
        _isCompleted = true;
        return -_penalty;
    }

    public override bool IsComplete()
    {
        return _isCompleted;
    }

    public override string ReturnGoal()
    {
        return $"NegativeGoal:{GetName()}|{GetDescription()}|{_penalty}|{_isCompleted}";
    }
}
