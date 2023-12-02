public abstract class Goal 
{
    public string _shortName;
    private string _description;
    public int _points;
    public bool _isCompleted;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isCompleted = false;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public string GetDetailsString()
    {
        string checkbox = _isCompleted ? "[X]" : "[ ]";
        string details = $"{checkbox} {_shortName}: {_description}";
        return details;
    }

    public abstract string GetStringRepresentation();
}
