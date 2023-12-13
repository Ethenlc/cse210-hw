public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string description, DateTime dateAndTime, string streetAddress, string speaker, int capacity)
        : base(title, description, dateAndTime, streetAddress)
    {
        _type = "Lecture";
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\n-Speaker: {_speaker}\n-Capacity: {_capacity}";
    }
}