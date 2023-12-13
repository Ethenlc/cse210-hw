public class OutdoorEvent : Event
{
    private string _weather;
    
    public OutdoorEvent(string title, string description, DateTime dateAndTime, string streetAddress, string weather)
        : base(title, description, dateAndTime, streetAddress)
        {
            _type = "Outdoor Gathering";
            _weather = weather;
        }

        public override string GetFullDetails()
        {
            return base.GetFullDetails() + $"\n-Weather: {_weather}";
        }
}