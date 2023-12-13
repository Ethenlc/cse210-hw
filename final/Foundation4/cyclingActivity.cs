public class CyclingActivity : Activity
{
    private double _distance;

    public CyclingActivity(DateTime date, int minutes, double distance)
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
        return base._minutes / _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Cycling - Distance {_distance} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min/mile";
    }
}