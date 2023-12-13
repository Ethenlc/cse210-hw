public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * .62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / base._minutes) *60;
    }

    public override double GetPace()
    {
        return base._minutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min/km";
    }
}