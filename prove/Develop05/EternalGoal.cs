public class EternalGoal : Goal
{
    private int _timesRecorded;
    private int _pointsEarned;

    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _timesRecorded = 0;
        _pointsEarned = 0;
    }

    public override void RecordEvent()
    {
        _timesRecorded++;
        _pointsEarned += _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetDetailsString()} - Points Earned: {_pointsEarned}";
    }
}
