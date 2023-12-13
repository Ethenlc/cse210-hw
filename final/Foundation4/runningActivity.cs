public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance/ base._minutes) *60;
    }

    public override double GetPace()
    {
        return base._minutes / _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running - Distance {_distance:F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min/mile";
    }
}