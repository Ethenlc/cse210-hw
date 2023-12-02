public class ChecklistGoal : Goal
{
    private int _timesRecorded;
    private int _bonusPoints;
    private int _pointsEarned;

    public ChecklistGoal(string name, string description, int points, int bonusPoints)
        : base(name, description, points)
    {
        _timesRecorded = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        _timesRecorded++;

        if (_timesRecorded <= _points)
        {
            _isCompleted = _timesRecorded == _points;
            _pointsEarned += _points;
        }
        else
        {
            _bonusPoints += _bonusPoints;
        }
    }

    public override bool IsComplete()
    {
        return _isCompleted;
    }

    public override string GetStringRepresentation()
    {
        string completionStatus = IsComplete() ? "Completed" : "Not Completed";
        return $"{base.GetDetailsString()} - {completionStatus} {_timesRecorded}/{_points} times - Bonus Points: {_bonusPoints}";
    }
}
