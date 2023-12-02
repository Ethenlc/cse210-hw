public class SimpleGoal : Goal
{
    private int _timesCompleted;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _timesCompleted = 0;
    }

    public override void RecordEvent()
    {
        if (!_isCompleted)
        {
            _timesCompleted++;
            _isCompleted = true;
            _points += (_timesCompleted == 1) ? _points : 0;
        }
    }

    public override bool IsComplete()
    {
        return _isCompleted;
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetDetailsString()} - Points Earned: {_points}";
    }
}
